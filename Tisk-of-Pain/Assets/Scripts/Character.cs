using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{


    public List<Vector3> teleportLocations = new List<Vector3>();

    public GameObject bullet;
    float jump = 10;
    float speed = 5;
    int jumpnum = 0;

    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rBody;

    // Use this for initialization
    void Start()
    {

        rBody = GetComponent<Rigidbody2D>();
        GameManager.Instance.MyCharacter = this;


    }

    // Update is called once per frame
    void Update()
    {

        velocity = rBody.velocity;
        if (Input.GetKeyDown(KeyCode.W) && jumpnum < 2)
        {

            velocity = new Vector3(velocity.x, jump);
            jumpnum++;
            AudioManager.Instance.PlayOneShot(SoundEffect.Jump);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            velocity = new Vector3(velocity.x, -jump);

        }

        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right * speed * Time.deltaTime;
        }

        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 5), velocity.y, 0);
        }

        rBody.velocity = new Vector3(Mathf.Clamp(velocity.x, -speed, speed), Mathf.Clamp(velocity.y, -jump * 3, jump), 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(bullet, transform.position, Quaternion.identity);

            obj.GetComponent<Rigidbody2D>().velocity = Vector3.up * 13;

        }



    }

    public void OnClickteleportButton()
    {
        transform.position = teleportLocations[Random.Range(0, teleportLocations.Count)];
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Ground" || collision.tag == "moving")
        {
            jumpnum = 0;
        }

        if (collision.tag == "bouncy")
        {
            jumpnum = 1;
        }


        if (collision.tag == "bouncy2")
        {
            jumpnum = 1;
        }

        if (collision.tag == "BIGGREENSQUARE")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jeremy : MonoBehaviour
{

    Transform Character;
    Vector3 velocity3;
    float speed3 = 30f;
    int num_of_hits2 = 0;

    // Use this for initialization
    void Start()
    {
        velocity3 = new Vector3(0, speed3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        velocity3 = (GameManager.Instance.MyCharacter.transform.position - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = velocity3 * Time.deltaTime * speed3;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "character")
        {

            collision.GetComponent<Character>().health = 0;
        }

        if (collision.tag == "bullet")
        {
            num_of_hits2++;
            Destroy(collision.gameObject);
        }

        if (num_of_hits2 == 70)
        {
            Destroy(gameObject);
        }

    }


}


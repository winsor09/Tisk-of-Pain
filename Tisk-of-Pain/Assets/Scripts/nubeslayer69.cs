using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nubeslayer69 : MonoBehaviour
{

    Transform Character;
    Vector3 velocity2;
    float speed2 = 200f;
    int num_of_hits2 = 0;

    // Use this for initialization
    void Start()
    {
        velocity2 = new Vector3(0, speed2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        velocity2 = (GameManager.Instance.MyCharacter.transform.position - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = velocity2 * Time.deltaTime * speed2;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "character")
        {

            collision.GetComponent<Character>().health--;
        }

        if (collision.tag == "bullet")
        {
            num_of_hits2++;
            Destroy(collision.gameObject);
        }

        if (num_of_hits2 == 5)
        {
            Destroy(gameObject);
        }

    }


}


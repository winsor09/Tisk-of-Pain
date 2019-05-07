using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    Transform Character;
    Vector3 velocity;
    float speed = 70f;
    int num_of_hits = 0;

    // Use this for initialization
    void Start()
    {
        velocity = new Vector3(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        velocity = (GameManager.Instance.MyCharacter.transform.position - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = velocity * Time.deltaTime * speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "character")
        {

            collision.GetComponent<Character>().health--;
        }

        if (collision.tag == "bullet")
        {
            num_of_hits++;
            Destroy(collision.gameObject);
        }

        if (num_of_hits == 15)
        {
            Destroy(gameObject);
        }

    }

   
}


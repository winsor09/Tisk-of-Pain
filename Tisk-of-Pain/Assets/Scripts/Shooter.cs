using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{

    public Rigidbody2D bullet;

    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        float input = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Quaternion rotation = Quaternion.LookRotation(transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);
        transform.rotation = rotation;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D bulletClone;
            bulletClone = Instantiate(bullet) as Rigidbody2D;

        }
    }
}
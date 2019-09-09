using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float speed = 15;
    private Rigidbody rb;
    private bool isRight = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x <= 1.1 && isRight) {
           // rb.AddForce(transform.right * speed * Time.deltaTime);
           transform.Translate(Vector3.right * Time.deltaTime);
        }
        else if (rb.position.x <= 1.1 && !isRight) {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if(rb.position.x >= 1) {
            // is now moving left
            isRight = false;
            //rb.AddForce(transform.right * speed * -1 * Time.deltaTime);
        }
        if (rb.position.x <= -3) {
            isRight = true;
            //rb.AddForce(transform.right * speed * Time.deltaTime);
           transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}

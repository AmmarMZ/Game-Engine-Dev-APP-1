using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float speed = 15;
    private Rigidbody rb;
    private bool isRight = true;

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb != null && rb.position.x <= 1.1 && isRight) {
           // rb.AddForce(transform.right * speed * Time.deltaTime);
           transform.Translate(Vector3.right * Time.deltaTime);
        }
        else if (rb != null && rb.position.x <= 1.1 && !isRight && rb != null) {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if(rb != null && rb.position.x >= 1) {
            // is now moving left
            isRight = false;
            //rb.AddForce(transform.right * speed * -1 * Time.deltaTime);
        }
        if (rb != null && rb.position.x <= -3) {
            isRight = true;
            //rb.AddForce(transform.right * speed * Time.deltaTime);
           transform.Translate(Vector3.right * Time.deltaTime);
        }

        if(rb != null && rb.position.z >= 15) {
            rb.gameObject.SetActive(false);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true;
            rb.angularDrag = 0.0f;
            rb.gameObject.transform.position = new Vector3(-1, 1, -4.05f);
            rb.transform.rotation = Quaternion.identity;
            rb.isKinematic = false;
            rb.gameObject.SetActive(true);

           
        }
    }
}

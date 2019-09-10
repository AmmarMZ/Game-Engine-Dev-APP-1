using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody rb;
    private bool isRight = true;
    public float zIndex = -5;
    public int numShot = 1;
    public static int totalShots = 1;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x <= 3.1 && isRight) {
           // rb.AddForce(transform.right * speed * Time.deltaTime);
           transform.Translate(Vector3.right * Time.deltaTime * speed);
           
        }
        else if (rb.position.x <= 3.1 && rb.position.x >= -5.1 && !isRight) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if(rb.position.x >= 3) {
            // is now moving left
            isRight = false;
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if (rb.position.x <= -5) {
            isRight = true;
            //rb.AddForce(transform.right * speed * Time.deltaTime);
           transform.Translate(Vector3.right * Time.deltaTime * speed);
           
        }

        if(rb != null && rb.position.z >= 15) {
            numShot++;
            totalShots++;
            speed+=2;
            rb.gameObject.SetActive(false);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true;
            rb.angularDrag = 0.0f;
            if (numShot == 6) {
                numShot = 1;
                speed +=3;
            }
            rb.gameObject.transform.position = new Vector3(GetRandomNumber(), 1, (zIndex + numShot*3));
            rb.transform.rotation = Quaternion.identity;
            isRight = true;
            rb.isKinematic = false;
            rb.gameObject.SetActive(true);
            return;
        }
        if (totalShots == 11) {
            Destroy(this.gameObject);
            GameOver.scoreText.gameObject.SetActive(true);
        }
    }
    public int GetRandomNumber()
    {
        System.Random ran = new System.Random();
        return ran.Next(-6, 4);
    }
}

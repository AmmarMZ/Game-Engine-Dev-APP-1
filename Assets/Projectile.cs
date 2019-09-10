using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 0.5f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, speed);

      
    }

    // Update is called once per frame
    void Update()
    {
          if (transform.position.z > 100 && this.gameObject != null) {
            Destroy(this.gameObject);
        }
    }


    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag.Equals("target")) {
            ScoreScript.score += 1;
            Destroy(this.gameObject);
        }
        else if (col.gameObject.tag.Equals("miss")) {
            ScoreScript.score -= 1;
            Destroy(this.gameObject);
        }
    }
}

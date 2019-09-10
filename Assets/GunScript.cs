using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
     public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
         {
             shootProjectile();
         }
    }

    public void shootProjectile() {
        GameObject b = Instantiate(projectile) as GameObject;
        b.transform.position = gameObject.transform.position;
        b.transform.position += new Vector3(0,0,5);
    }
}

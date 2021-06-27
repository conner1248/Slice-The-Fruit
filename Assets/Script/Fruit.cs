using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject Slice;
    public float count;
    public GameObject Splash;
    
    public GameObject particle;
    
    


    Rigidbody2D rb;
    public float startForce = 15f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }
   void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Blade")
        {
            

            GameObject particleSystem = Instantiate(particle, transform.position, transform.rotation);
            Destroy(particleSystem, 3f);
            

            Vector3 direction = (col.transform.position - transform.position).normalized;
            Quaternion rotation = Quaternion.LookRotation(direction);
            
            
            GameObject slicedFruit = Instantiate(Slice, transform.position,rotation);

            GameObject splash = Instantiate(Splash, transform.position, transform.rotation);


            Destroy(splash, 3f);
            Destroy(slicedFruit, 3f);
            Destroy(gameObject);
            
             
        }
    }

    
}

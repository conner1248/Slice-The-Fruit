using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour
{
   public int count;
    public AudioSource slash;
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Watermelon")
        {
            slash.Play();

            count += 20;
           // Debug.Log("Count = " + count);
        }
    }
}

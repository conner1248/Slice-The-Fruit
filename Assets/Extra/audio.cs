using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource audioSource;
    void Update()
    {
        

       
        if(Time.timeScale == 0)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.UnPause();

        }
    }
}

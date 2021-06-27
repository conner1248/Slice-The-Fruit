using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    bool isTrue = false;
    public Text countText;
   
    public GameObject pauseMenu;
    float time = 3f;


    void Start ()
    {
        pauseMenu.active = false;
        countText.enabled = false;
    }

    void Update()
    {
        
        
        if (isTrue)
        {
            Debug.Log("working");

            countText.enabled = true;
            time -= Time.unscaledDeltaTime;                        
            countText.text = time.ToString("0");
            
            
        }

    }

    public void pauseGame()
    {
        Time.timeScale = 0f;

        pauseMenu.active = true;
    }

    public void resumeGame()
    {

        StartCoroutine(pauseCount());

    }
    
    public IEnumerator pauseCount()
    {
        isTrue = true;
        float time = 3f;

        pauseMenu.active = false;
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 1f;
        isTrue = false; 
        countText.enabled = false;
    }



    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }


    public void quitGame()
    {
        Application.Quit();
    }
}



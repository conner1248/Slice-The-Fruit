
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject contain;
    float c;
    public Melon melon;

    float HighScore = 0;
    public Text scoreText;
    public Text highScore;
    
    // Update is called once per frame
    void Start()
    {
        melon = contain.GetComponent<Melon>();
        HighScore = PlayerPrefs.GetFloat("HighScore");
        highScore.text = "HighScore : " + HighScore.ToString();
    }

    void Update()
    {
        //  Debug.Log("Counter" + melon.count);
        c = melon.count;
        //Debug.Log("Score : " + c);
        scoreText.text = "Score : " + melon.count.ToString();
        if (c > HighScore)
        {
            HighScore = c;
            PlayerPrefs.SetFloat("HighScore", HighScore);
            highScore.text = "HighScore : " + HighScore.ToString();
        }
        PlayerPrefs.SetFloat("HighScore", HighScore);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
    private float timeLeft = 120;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public Text playerScoreUI;
  
    void Update()
    {
       
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        if (timeLeft < 0.1f)
        {
            SceneManager.LoadScene("SampleScene");
            
        }
    }
    void OnTriggerEnter2D (Collider2D trig){
        Debug.Log(trig.gameObject.name);

        if (trig.gameObject.name == "EndLevel"){
            CountScore();
        }
        if (trig.gameObject.CompareTag("coin")){
            playerScore += 10;
            playerScoreUI.text = "Score: " + playerScore.ToString();
            Destroy(trig.gameObject);
        }

        if (trig.gameObject.CompareTag("enemy"))
        {
                SceneManager.LoadScene("SampleScene");
            Debug.Log("fuck this");
            }

    }
    void CountScore ()
    {
        playerScore = playerScore + (int)(timeLeft * 10);
        Debug.Log(playerScore);

    }
}

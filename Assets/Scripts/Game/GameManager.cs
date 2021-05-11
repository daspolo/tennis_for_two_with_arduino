using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;
    private Vector3 spawnPoint;


    [SerializeField]
    TMP_Text textScorePlayer_1;
    [SerializeField]
    TMP_Text textScorePlayer_2;
    [SerializeField]
    GameObject ball;


    private void Start()
    {
        spawnPoint = ball.transform.position;
    }

  
    public void respawn()
    {
        if(ball.transform.position.x < 0)
        {
            scorePlayer2++;
            textScorePlayer_2.text = scorePlayer2.ToString();

            ball.transform.position = new Vector3(spawnPoint.x * -1, spawnPoint.y, spawnPoint.z);
        }
        else
        {
            scorePlayer1++;
            textScorePlayer_1.text = scorePlayer1.ToString();

            ball.transform.position = spawnPoint;
        }
        
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))       
            Application.Quit();
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionDetector : MonoBehaviour
{

    public Text score;

    private int currentScore = 0;


    private void Start()
    {
        SetScore(0);
    }

    private void SetScore(int currentScore)
    {
        score.text = $"Score: {currentScore.ToString()}";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GameOver")
        {
            HandleGameOver();
        }
        else
        {
            DispatchPointAddEvent();
        }
    }

    private void DispatchPointAddEvent()
    {
        currentScore += 1;
        SetScore(currentScore);
    }

    private void HandleGameOver()
    {
        Debug.Log("Game Over :c");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Constants;

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
        score.text = $"Score: {currentScore}";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == Tags.AddPoint)
        {
            DispatchPointAddEvent();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == Tags.GameOver)
        {
            HandleGameOver();
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

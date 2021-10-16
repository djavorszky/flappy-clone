
using UnityEngine;
using Constants;
using Service;

public class CollisionDetector : MonoBehaviour
{
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
        ScoreService.Increment();
    }

    private void HandleGameOver()
    {
        Debug.Log("Game Over :c");
    }

}

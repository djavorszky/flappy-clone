
using UnityEngine;
using Constants;

public class CollisionDetector : MonoBehaviour
{

    public IntData score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.AddPoint))
        {
            score.Increment();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.GameOver))
        {
            HandleGameOver();
        }
    }


    private void HandleGameOver()
    {
        Debug.Log("Game Over :c");
    }

}

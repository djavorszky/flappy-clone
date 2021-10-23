
using UnityEngine;
using Constants;

public class CollisionDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.AddPoint))
        {
            DispatchPointAddEvent();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.GameOver))
        {
            HandleGameOver();
        }
    }

    private void DispatchPointAddEvent()
    {
        Debug.Log("Increment!");
    }

    private void HandleGameOver()
    {
        Debug.Log("Game Over :c");
    }

}

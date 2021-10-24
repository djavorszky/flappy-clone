
using UnityEngine;
using UnityEngine.Events;
using Constants;

public class CollisionDetector : MonoBehaviour
{

    public UnityEvent scoreEvent = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.AddPoint))
        {
            scoreEvent.Invoke();
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

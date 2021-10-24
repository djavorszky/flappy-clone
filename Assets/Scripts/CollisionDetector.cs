
using UnityEngine;
using UnityEngine.Events;
using Constants;

public class CollisionDetector : MonoBehaviour
{

    public UnityEvent scoreEvent = new UnityEvent();
    public UnityEvent gameOverEvent = new UnityEvent();
    public UnityEvent boingEvent = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.AddPoint))
        {
            scoreEvent.Invoke();
        } 
        else if (collision.gameObject.CompareTag(Tags.Mun))
        {
            boingEvent.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.GameOver))
        {
            Debug.Log("Game Over :c");

            gameOverEvent.Invoke();
        }
    }
}

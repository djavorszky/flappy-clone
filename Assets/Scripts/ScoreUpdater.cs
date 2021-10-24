using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    public TMP_Text textMenu;
    
    private int score = 0;

    public void Increment()
    {
        score++;

        textMenu.text = $"Score: {score}";
    }
}

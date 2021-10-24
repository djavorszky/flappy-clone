using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    public TMP_Text textMenu;

    public IntData score;

    private void Start()
    {
        score.Value = 0;
    }

    public void Increment()
    {
        score.Value++;

        textMenu.text = $"Score: {score.Value}";
    }
}

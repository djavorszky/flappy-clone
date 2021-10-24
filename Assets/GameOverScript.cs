using UnityEngine;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public IntData score;

    public TMP_Text scoreText;

    private void OnEnable()
    {
        scoreText.text += score.Value;
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{

    public IntData score;

    private Text textMenu;

    void Start()
    {
        score.Value = 0;

        textMenu = GetComponent<Text>();
        textMenu.text = "Score: 0";

        score.OnChange(newScore => textMenu.text = $"Score: {newScore}");
    }
}

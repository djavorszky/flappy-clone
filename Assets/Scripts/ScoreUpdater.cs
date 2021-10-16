using UnityEngine;
using UnityEngine.UI;
using Service;

public class ScoreUpdater : MonoBehaviour
{

    private Text textMenu;

    void Start()
    {
        textMenu = GetComponent<Text>();
        textMenu.text = "Score: 0";

        ScoreService.OnScoreChange(score => textMenu.text = $"Score: {score}");
    }
}

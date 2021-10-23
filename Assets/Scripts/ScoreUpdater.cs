using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{

    public IntData score;

    private Text textMenu;

    void Start()
    {
        textMenu = GetComponent<Text>();
        textMenu.text = $"Score: {score.Value}";
    }
}

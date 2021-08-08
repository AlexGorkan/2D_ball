using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ballsDroppedText;
    [SerializeField] private ScoreManager scoreManager;



    public void UpdateScore()
    {
        ballsDroppedText.text = scoreManager.BallsDropped.ToString();

    }



}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ScoreManager", menuName = "ScriptableObjects/NewScoreManager")]
public class ScoreManager : ScriptableObject
{

    [SerializeField] private int ballsDropped;
    

    public int BallsDropped { get { return ballsDropped; } }

    

    private void OnEnable()
    {
        ballsDropped = 0;
        
    }

    public void AddBallsDropped()
    {
        ballsDropped++;
    }
   
}


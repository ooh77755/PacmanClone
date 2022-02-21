using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    int score = 0;
    int totalScore = 920;

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int points)
    {
        score += points;
        if(score == totalScore)
        {
            SceneManager.LoadScene(1);
        }
    }
}

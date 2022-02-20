using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = FindObjectOfType<GameSession>().GetScore().ToString();
    }
}

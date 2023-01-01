using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    
    public int scoreValue = 0;
    public TMP_Text scoreText;
    

    public void IncreaseScore()
    {
        scoreValue++;
        scoreText.text = scoreValue.ToString();
    }
}

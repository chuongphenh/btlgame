using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText; 
    public static int score = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score" + score;
    }
}

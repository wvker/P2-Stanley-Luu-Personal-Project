using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;


    int score = 0;
    int highscore= 0;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddPoint()
    {
        score += 10;
        scoreText.text = score.ToString() + " POINTS";
    
    }
}

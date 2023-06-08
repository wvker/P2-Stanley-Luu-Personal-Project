using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    private void Awake()
    {
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // This is where the gameover screen will activate
    void Update()
    {
         
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }
}

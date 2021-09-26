using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyHunting_Difficulty : MonoBehaviour
{

    private int maxTime;
    private bool lose = false;

    // Start is called before the first frame update
    void Start()
    {
        if(GameController.Instance.gameDifficulty == 1)
        {
            GameController.Instance.SetMaxTimer(15);
            maxTime = 15;
        }

        if (GameController.Instance.gameDifficulty == 2)
        {
            GameController.Instance.SetMaxTimer(10);
            maxTime = 10;
        }

        if (GameController.Instance.gameDifficulty == 3)
        {
            GameController.Instance.SetMaxTimer(5);
            maxTime = 5;
        }
    }

    void Update()
    {
        if(GameController.Instance.gameTime >= maxTime)
        {
            if (lose == false)
            {
                lose = true;
                //GameController.Instance.LoseGame();
            }
        }
    }
}

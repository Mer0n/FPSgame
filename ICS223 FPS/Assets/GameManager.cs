using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] BallMovement ball;
    [SerializeField] UIManager ui;
    float xMax = 14;
    float xMin = -14;
    int scoreP1 = 0;
    int scoreP2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        ui.UpdateScore(scoreP1,scoreP2);
        ball.Reset();
        ball.Launch(GetRandomBallDirection());
    }

    Vector3 GetRandomBallDirection()
    {
        int xDir = 1;
        if (Random.Range(0, 2) == 0)
        {
            xDir = -1;
        }
        int yDir = 1;
        if (Random.Range(0, 2) == 0)
        {
            yDir = -1;
        }
        return new Vector3(xDir, yDir, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x > xMax)
        {
            scoreP1 += 1;

            ball.Reset();
            ball.Launch(GetRandomBallDirection());
            ui.UpdateScore(scoreP1, scoreP2);
        }
        else if (ball.transform.position.x < xMin)
        {
            scoreP2 += 1;
            ball.Reset();
            ball.Launch(GetRandomBallDirection());
            ui.UpdateScore(scoreP1, scoreP2);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;

    private bool isGameOver = false;
    private float timer = 0f;

    void Update()
    {
        if (!isGameOver)
        {
            timer += Time.deltaTime;
        }

        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }

    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 80, 200, 100);
            GUI.Box(rect, "Game Over");

            Rect rect2 = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 40, 120, 30);
            GUI.Label(rect2, "Good Job!");

            Rect rect3 = new Rect(Screen.width / 2 - 80, Screen.height / 2 + 10, 160, 30);
            GUI.Label(rect3, "Time: " + timer.ToString("F2") + " seconds");
        }
    }
}
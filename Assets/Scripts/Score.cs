using System.IO.Pipes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Score : MonoBehaviour
{
    public GameController controller;

    void Start() 
    {
        controller = FindObjectOfType<GameController>();
    }

    void OnTriggerEnter2D(Collider2D colider)
    {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}

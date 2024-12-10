using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    public string playerName;
    public int points = 0;
    public float size;
    public int speed;
    public int health = 100;
    public int highScore = 0;


    public PlayerClass(string playerName, int points, float size, int speed, int health, int highScore)
    {
        this.playerName = playerName;
        this.points = points;
        this.size = size;
        this.speed = speed;
        this.health = health;
        this.highScore = highScore;

    }

} 


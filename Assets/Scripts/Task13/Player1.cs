using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1
{
    public string playerName;
    public int health;
    public static int playerCount;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(playerName + " has been healed by " + amount + " points. Current health: " + health);
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100; 
            Debug.Log(playerName + " has been fully restored.");
        }
        else
        {
            Debug.Log("Full restore is not enabled.");
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log("Total number of players: " + playerCount);
    }
}


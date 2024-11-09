using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   void Start()
    {
       Player1 player1 = new Player1();
        player1.InitializePlayer("Player 1", 100);
        player1.Heal(20);
        player1.Heal(true);
        Player1.ShowPlayerCount();
    }

}

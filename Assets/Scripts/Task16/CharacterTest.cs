using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
          
            Character[] characters = new Character[]
            {
                new Soldier("John", 80, new Position(1, 2, 3)),
                new Officer("Captain", 90, new Position(4, 5, 6))
            };

        
            foreach (var character in characters)
            {
                character.DisplayInfo();
            }

            Officer officer = (Officer)characters[1];
            Soldier soldier = (Soldier)characters[0];

            Debug.Log($"Soldier's health before attack: {soldier.Health}");
            officer.Attack(20, soldier, "shooting");
            Debug.Log($"Soldier's health after attack: {soldier.Health}");
        }
    }
}


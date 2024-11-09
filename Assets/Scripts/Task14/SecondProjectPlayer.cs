using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondProjectPlayer : MonoBehaviour
{
    void Start()
    {
        Character player = new Character("أبو علي", 100);
        Enemy enemy = new Enemy("الوحش", 50);

        Debug.Log("اسم اللاعب: " + player.Name + ", صحته: " + player.Health);
        Debug.Log("اسم العدو: " + enemy.Name + ", صحته: " + enemy.Health);

        player.Health += 20;
        enemy.Attack(player, 15);

        Debug.Log("بعد الشفاء والهجوم:");
        Debug.Log("اسم اللاعب: " + player.Name + ", صحته: " + player.Health);
        Debug.Log("اسم العدو: " + enemy.Name + ", صحته: " + enemy.Health);
    }
}

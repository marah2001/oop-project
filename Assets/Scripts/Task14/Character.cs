using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name { get; set; } // اسم الشخصية
    public int Health { get; set; } // صحة الشخصية

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

// كلاس اللاعب (بيرث من Character)




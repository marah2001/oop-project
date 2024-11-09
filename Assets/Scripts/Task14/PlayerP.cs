using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerP : Character
{
    public PlayerP(string name, int health) : base(name, health)
    {
    }

    public void Heal(int amount)
    {
        Health += amount;
        Debug.Log(Name + " تم شفائه بـ " + amount + " نقطة. الصحة الحالية: " + Health);
    }
}
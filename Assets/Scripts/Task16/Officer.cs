using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class Officer : Character
    {
       
        public Officer(string name, int health, Position position) : base(name, health, position) { }

      
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}

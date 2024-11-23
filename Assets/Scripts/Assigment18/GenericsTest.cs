using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> container = new GameContainer<string>();
        container.SetItem("Healing Potion");

        Debug.Log("Stored item: " + container.GetItem());
        Debug.Log(GameUtils.DescribeItem(container.GetItem()));
    }
}

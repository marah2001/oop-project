using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory potionInventory = new Inventory();
        potionInventory.AddItem("Healing Potion");
        potionInventory.AddItem("Strength Potion");

        Inventory elixirInventory = new Inventory();
        elixirInventory.AddItem("Elixir");
        elixirInventory.AddItem("Dark Elixir");

        Inventory combinedInventory = potionInventory + elixirInventory;
        combinedInventory.ShowItems();
    }
}

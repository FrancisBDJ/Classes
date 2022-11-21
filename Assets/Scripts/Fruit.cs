using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Fruit : Item
{
    [SerializeField]
    private int health;

    public Fruit(string itemName, int id, string description, int health) : base(itemName, id, description)
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return this.health;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Coin : Item
{
    [SerializeField] 
    private int points;

    public Coin(string itemName, int id, string description, int points) : base(itemName,id,description)
    {
        
        this.points = points;
    }
}

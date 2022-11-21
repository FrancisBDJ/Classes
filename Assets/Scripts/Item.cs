using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Item 
{   
    [SerializeField]
    private string itemName;
    [SerializeField]
    private int id;
    [SerializeField]
    private string description;
    
    

    public Item(string itemName, int id, string description)
    {
        this.itemName = itemName;
        this.id = id;
        this.description = description;
    }

    public string GetItemName()
    {
        return this.itemName;
    }

    


}

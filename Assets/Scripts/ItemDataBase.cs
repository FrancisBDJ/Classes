using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase: MonoBehaviour
{
    [SerializeField]
    private Item[] items;

    [SerializeField]
    private Item Coin;


    [SerializeField] 
    private Item Fruit;
    
    
    
    
    private void Start()
    {
        items = new Item[2];
        items[0] = new Coin("Coin20", 0, "coin collectable", 20);
        items[1] = new Fruit("Apple", 1, "Fruit Collectible", 10);

        //Versio1 

        // Debug.Log(items[0].GetItemName());//

        /* Versio2 mostra tots
         foreach (var item in items)
         {
             Debug.Log(item.itemName);
         }*/

    }

    private void DamageHealth(health)
    {
        return Coin.GetHealth() - 10;
    }

    private void Update()
    {
        Input.GetKeyDown(KeyCode.C)
        {
            DamageHealth()
        }
    }
}

    
  


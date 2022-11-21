using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField]
    private WeaponStats blasters;
    [SerializeField]
    private WeaponStats rockets;
    
    // Start is called before the first frame update
    void Start()
    {
        blasters = new WeaponStats("Blasters", .25f, 50);

        rockets = new WeaponStats("Rockets", 5f, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

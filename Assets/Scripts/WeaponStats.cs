using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class WeaponStats
{
    
        [SerializeField]
        private string wName;
        [SerializeField]
        private float fireRate;
        [SerializeField]
        private int ammoCount;
        
        
    
        public WeaponStats(string wName, float fireRate, int ammoCount)
        {
            this.wName = wName;
            this.fireRate = fireRate;
            this.ammoCount = ammoCount;

        }
        
    
  
}

using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CustomerDB: MonoBehaviour
{
    [SerializeField] 
    public Customer[] customerDB;
    
   

    private void Start()
    {
        
        customerDB = new Customer[4];
        customerDB[0] = new Customer("Francis ", "Daniele ", 38 , "M " , "Student");
        customerDB[1] = new Customer("Marta ", "Torres ", 30 , "F " , "Teacher");
        customerDB[2] = new Customer("Luis ", "Devis ", 25 , "M " , "Student");
        customerDB[3] = new Customer("Devi ", "Lopez ", 19 , "M " , "Student");
        
        
    }

    private void GetCustomer()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            foreach (var customer in customerDB)
            {
                Debug.Log(customer);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Debug.Log(customerDB[0].ToString());
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(customerDB[1].ToString());
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(customerDB[2].ToString());
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(customerDB[3].ToString());
        } 
        
         if (Input.GetKeyDown(KeyCode.G))
        {
            foreach (var customer in customerDB)
            {
                if (customer.GetGender() == "M ")
                {
                    Debug.Log(customer);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            foreach (var customer in customerDB)
            {
               // customer.Add3toAge();
               customer.SetAge(customer.GetAge() + 3);
                Debug.Log(customer);
            }
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            foreach (var customer in customerDB)
            {
                if (customer.GetName().Contains("a"))
                {
                    Debug.Log(customer);
                }
            }
        }
        
        
    }

    private void Update()
    {
        
        GetCustomer();
       
    }
    
}


using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class Customer
{
    [SerializeField] private string firstName;
    [SerializeField] private string lastName;
    [SerializeField] private int age;
    [SerializeField] private string gender;
    [SerializeField] private string occupation;

    public Customer(string firstName, string lastName, int age, string gender, string occupation)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }

    public override string ToString()
    {
        return ("firstName: " + this.firstName + "lastName: " + this.lastName + "age: " + this.age + " gender: " + this.gender +
            "occupation: " + this.occupation);
    }

    public string GetGender()
    {
        return this.gender;
    }

    public int GetAge()
    {
        return this.age;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
    
    public void Add3toAge()
    {
         this.age = this.age + 3;
    }
    

    public string GetName()
    {
        return (this.firstName + this.lastName);
    }

}
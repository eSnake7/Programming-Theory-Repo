using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public Dog(){
        setName("Figo"); // ENCAPSULATION
    }

    public void Bark()
    {
        Debug.Log("Animal " + getName() + " has barked!");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public Cat()
    {
        setName("Tobias"); // ENCAPSULATION
    }

    public void Meow()
    {
        Debug.Log("Animal " + getName() + " has meowed!");
    }
}

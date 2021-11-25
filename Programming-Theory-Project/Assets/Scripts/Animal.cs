using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected string animalName { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void setName(string name)
    {
        if (name.Length > 15)
        {
            animalName = "smaller_name";
        }
        else { 
            animalName = name;
        }
    }

    protected string getName()
    {
        return animalName;
    }

    public void Jump()
    {
        Debug.Log("Animal " + animalName + " has jumped.");
    }
   
}

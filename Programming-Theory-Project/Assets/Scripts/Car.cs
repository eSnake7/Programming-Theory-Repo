using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{

    public Car()
    {
        setVehicleYear(2003);
    }

    public void Go()
    {
        Debug.Log("Car from " + vehicleYear + " is going.");
    }
}

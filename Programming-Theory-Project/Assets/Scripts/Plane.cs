using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
{
    public Plane()
    {
        setVehicleYear(1990);
    }

    public void Fly()
    {
        Debug.Log("Plane from " + vehicleYear + " is flying.");
    }
}

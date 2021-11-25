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

    public override void Honk() // POLYMORPHISM
    {
        Debug.Log("Plane warns passangers before loud honk.");
        base.Honk();
    }
}

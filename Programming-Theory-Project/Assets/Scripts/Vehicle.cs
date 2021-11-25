using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected int vehicleYear { get; set; }

    protected void setVehicleYear(int year)
    {
        if(year < 0)
        {
            Debug.Log("For some reasons cars from the year 10 are fine, but before 0 no!");
        }
        else { 
            vehicleYear = year;
        }
    }

    protected int getVehicleYear()
    {
        return vehicleYear;
    }

    public void Honk()
    {
        Debug.Log("Vehicle from " + vehicleYear + " has honked.");
    }
}

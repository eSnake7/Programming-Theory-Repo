using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Cat cat;
    private Dog dog;
    private Plane plane;
    private Car car;

    // Start is called before the first frame update
    void Start()
    {
        cat = new Cat();
        dog = new Dog();
        plane = new Plane();
        car = new Car();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if( Physics.Raycast(ray, out hit, 100))
            {
                if(hit.transform.gameObject.name == "AnimalCube")
                {
                    cat.Jump(); // INHERITANCE
                    dog.Jump(); // INHERITANCE
                }
                else if (hit.transform.gameObject.name == "VehicleSphere")
                {
                    plane.Honk(); // INHERITANCE
                    car.Honk(); // INHERITANCE
                }
                else if (hit.transform.gameObject.CompareTag("Dog"))
                {
                    dog.Bark(); // ABSTRACTION
                }
                else if (hit.transform.gameObject.CompareTag("Cat"))
                {
                    cat.Meow(); // ABSTRACTION
                }
                else if (hit.transform.gameObject.CompareTag("Plane"))
                {
                    plane.Fly(); // ABSTRACTION
                }
                else if (hit.transform.gameObject.CompareTag("Car"))
                {
                    car.Go(); // ABSTRACTION
                }
            }
        }
    }
}

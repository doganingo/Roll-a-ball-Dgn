using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplanacak : MonoBehaviour
{
    Vector3 vec;
    void Start()
    {
        vec = new Vector3(15,30,45);
    }

    
    void Update()
    {
        transform.Rotate(vec * Time.deltaTime);
        //transform.Rotate(new Vector3(15,30,45) * Time.deltaTime)
    }
}

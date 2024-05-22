using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(1.0f, 1.0f, 1.0f));
    }
}

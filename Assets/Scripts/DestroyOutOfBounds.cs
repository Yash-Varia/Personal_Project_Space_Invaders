using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{   
    //Set offfscreen position
    private float outOfBounds = 55f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //Destry object when offscreen
        if(transform.position.z > outOfBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < -outOfBounds)
        {
            Destroy(gameObject);
        }
    }
}

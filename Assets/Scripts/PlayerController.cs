using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    //player speeed and movement Range
    private float verticalSpeed = 35f;
    private float horizontalSpeed = 50f;
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 33f;
    private float zRange = 44f;
    //player initial position
    private Vector3 initialPosition = new Vector3(0f, 2f, -40f);
    //bullet prefab
    public GameObject bulletPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {   
        //Take horizontal movement input and apply to player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * verticalInput);

        //Apply player Boundary
        SetMovementBoundary();

        //spawn bullet after interval
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 5f), transform.rotation);
        }
    }

    void SetMovementBoundary()
    {
        //Set the boundary for player movement
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

    }

    /*
    void SetMovementRotation()
    {
        //Tilt the plane on moement
        if (horizontalInput > 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + 20f);
        }

        if (horizontalInput < 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + -20f);
        }

        if (verticalInput > 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x + 20f, transform.rotation.y, transform.rotation.z);
        }

        if (verticalInput < 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x + -20f, transform.rotation.y, transform.rotation.z);
        }
    }
    */
}

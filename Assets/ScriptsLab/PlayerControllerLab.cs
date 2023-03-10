using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerLab : MonoBehaviour
{
    private float speed = 10;
    private float zBound = 3;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        if(transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if(transform.position.z > zBound*4)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound * 4);
        }
    }
}

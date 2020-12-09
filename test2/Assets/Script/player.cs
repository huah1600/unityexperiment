using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private bool pressedkey;
    private float HorizontalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressedkey = true;

        }
        HorizontalInput = Input.GetAxis("Horizontal");

    }
    private void FixedUpdate()
    {
        if (pressedkey)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            pressedkey = false;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(HorizontalInput, GetComponent<Rigidbody>().velocity.y, 0);


    }
}

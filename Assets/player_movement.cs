using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed =5;
    public float rotSpeed = 5;
    private Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Horizontal"),0) * Time.fixedDeltaTime *rotSpeed));
    }
}

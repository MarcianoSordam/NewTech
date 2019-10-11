using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveVR : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 movement;
    //private Rigidbody rb;
    private Transform cam;

    private void Awake()
    {

    }
    void FixedUpdate()
    {
        Vector3 forward = Vector3.Scale(new Vector3(1, 0, 1), cam.forward);
        Vector3 right = Vector3.Scale(new Vector3(1, 0, 1), cam.right);
        movement = (forward.normalized * Input.GetAxis("Vertical") + right.normalized * Input.GetAxis("Horizontal"));
        movement = Vector3.ClampMagnitude(movement * speed, speed);
        transform.Translate(movement, Space.World);
        //rb.MovePosition(transform.position + movement * Time.deltaTime);



        /*
        if (Input.GetButtonDown("Dodge") && dodgeCheck == false)
        {
            StartCoroutine (dodge());
        }
        */
    }
}

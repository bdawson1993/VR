using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaController : MonoBehaviour
{
    public float speed;


    Vector3 direc = Vector3.forward;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(direc * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
     
    }

    private void LateUpdate()
    {
        GetComponent<Rigidbody>().velocity = (direc * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        direc = collision.GetContact(0).normal;
    }
}

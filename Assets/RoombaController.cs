using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaController : MonoBehaviour
{
    Vector3 direc = Vector3.forward;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(direc * 8.0f);
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        direc = -direc;
    }
}

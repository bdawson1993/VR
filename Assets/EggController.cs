using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inside;
    public GameObject brokenShell;

    Rigidbody outerShellRB;

    OVRGrabbable grabber;

    void Start()
    {
        outerShellRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(outerShellRB.velocity.magnitude);

        if(outerShellRB.velocity.magnitude >= 1)
        {
            inside.SetActive(true);
            inside.transform.position = transform.position;


            brokenShell.SetActive(true);
            brokenShell.transform.position = transform.position;


            gameObject.SetActive(false);
        }
    }

    
}

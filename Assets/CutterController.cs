using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterController : MonoBehaviour
{
    public GameObject chips;
    public GameObject spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Food")
        {
            Destroy(other);
            Instantiate(chips, spawnLocation.transform.position, spawnLocation.transform.rotation);
        }

        
    }
}

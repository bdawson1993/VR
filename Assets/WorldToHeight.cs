using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldToHeight : MonoBehaviour
{
    bool hasFloorBeenFound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasFloorBeenFound)
            transform.Translate(Vector3.up * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        hasFloorBeenFound = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TrackerAnimater : MonoBehaviour
{
    public ParentConstraint parent;
    float currentX;

    float lastX;
    float deltaX;



    // Start is called before the first frame update
    void Start()
    {
        parent = GetComponent<ParentConstraint>();
        currentX = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        deltaX = (transform.position.x - lastX);
        lastX = transform.position.x;
        //Debug.Log(deltaX);
    }
}

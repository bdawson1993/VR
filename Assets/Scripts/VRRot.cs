using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRot : MonoBehaviour
{
    public Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OVRPose pos = transform.ToTrackingSpacePose(Camera.current);
        transform.position.Set(pos.position.x, pos.position.y, pos.position.z);
        transform.rotation.Set(pos.orientation.x, pos.orientation.y, pos.orientation.z, pos.orientation.w);
    }
}

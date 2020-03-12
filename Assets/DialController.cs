using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialController : OVRGrabbable
{
    Vector3 startPos;
    Quaternion startRot;
    OVRGrabber m_hand;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        startPos = transform.position;
        startRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (isGrabbed)
        {
            transform.position = startPos;

            //Quaternion newRot = Quaternion.Euler(startRot.x, m_hand.transform.rotation.y, startRot.z);
            //transform.rotation = newRot;
        }
    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        m_hand = hand;
        hand.ParentHeld = false;
        base.GrabBegin(hand, grabPoint);
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        m_hand.ParentHeld = true;
        base.GrabEnd(linearVelocity, angularVelocity);
    }



}

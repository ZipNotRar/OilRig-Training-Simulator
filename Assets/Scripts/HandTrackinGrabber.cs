using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using System;

public class HandTrackinGrabber : OVRGrabber
{
    private OVRHand hands;
    public float pinchThreshold = .7f;
    protected override void Start()
    {
        base.Start();
        hands = GetComponent<OVRHand>();
    }
    public override void Update()
    {
        base.Update();
        checkIndexPinch();
    }

    void checkIndexPinch()
    {
        float pinchStrength = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Index);
        bool isPinching = pinchStrength > pinchThreshold;

        if (!m_grabbedObj && isPinching && m_grabCandidates.Count > 0)
        {
            GrabBegin();
        }
        else if (m_grabbedObj && !isPinching)
        {
            GrabEnd();
        }
    }
}

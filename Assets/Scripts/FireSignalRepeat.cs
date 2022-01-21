using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSignalRepeat : MonoBehaviour
{
    public Animator fsAnimator;
    public RuntimeAnimatorController fsanimController;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FireSignalEvent", 30f, 30.0f);
    }
    void FireSignalEvent()
    {
        fsAnimator.enabled = true;
        fsAnimator.runtimeAnimatorController = fsanimController;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class LeverEvents : MonoBehaviour
{
    [SerializeField] private HingeJoint leverJoint;
    public UnityEvent onPulled, onPushed;
    // Start is called before the first frame update
    void Start()
    {
        leverJoint = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.x < 10)
        {
            onPulled.Invoke();
        }
        if (transform.rotation.x > 0)
        {
            onPushed.Invoke();
        }
    }


}

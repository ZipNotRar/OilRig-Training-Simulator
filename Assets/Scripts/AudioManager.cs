using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public bool rw1 = false;
    public AudioSource as1;

    private void OnTriggerStay(Collider other) {
        if (other.name == "Cubo")
        {
            rw1 = true;
            if (rw1 == true)
            {
                Debug.Log("play recording now");
                as1.Play();
            }
        }

    }
}

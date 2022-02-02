using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource doorSound;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.GetComponent<doorCollision>())
        {
        doorSound.Play();
        }
    }
}

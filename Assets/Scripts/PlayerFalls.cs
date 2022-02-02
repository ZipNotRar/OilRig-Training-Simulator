using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFalls : MonoBehaviour
{
    public Transform fallThreshold;
    public Transform spawnPoint;

    private void Update()
    {
        if (this.transform.position.y < fallThreshold.transform.position.y)
        {
            this.transform.position = spawnPoint.transform.position;
        }
    }
}

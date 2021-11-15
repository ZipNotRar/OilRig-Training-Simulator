using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    public void move(){
        transform.position = new Vector3(transform.position.x+5, 0, 0) * speed * Time.deltaTime;
    }
}

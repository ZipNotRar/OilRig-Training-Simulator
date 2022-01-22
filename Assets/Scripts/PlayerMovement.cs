using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 moveDirection;
    public CharacterController cc;
    public float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
      cc = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    public void move(){
        moveDirection = transform.TransformDirection(Vector3.forward)*speed;
        var flags = cc.Move(moveDirection*Time.deltaTime);
    }
}

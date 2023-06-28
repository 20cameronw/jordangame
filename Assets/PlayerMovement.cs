using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // [SerializeField]
    // private CharacterController2D controller;

    [SerializeField]
    private float runSpeed = 40f;

    private float horizontalMove = 0f;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

    void FixedUpdate() {

    }
}

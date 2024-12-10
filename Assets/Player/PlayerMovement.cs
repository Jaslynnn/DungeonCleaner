using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerClass playerClass;
    private Rigidbody2D rb;
    private float moveH, moveV;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal") * playerClass.speed;
        moveV = Input.GetAxis("Vertical") * playerClass.speed;
        rb.velocity = new Vector2(moveH, moveV);
    }

    

}

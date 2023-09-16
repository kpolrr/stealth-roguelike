using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody2D rb;
    Vector2 input;

    // Update is called once per frame
    // im a genius and thought that topdown movement was normally done with custom controller/physics cos its simple but its platformer
    void Update()
    {
        //vectors normallized so that the player doesnt move faster diagonally
        input = new Vector2(Input.GetAxisRaw("Horizontal") * Time.deltaTime, Input.GetAxisRaw("Vertical") * Time.deltaTime).normalized;
    }

    void FixedUpdate() {
        rb.velocity = input * speed;
    }
}

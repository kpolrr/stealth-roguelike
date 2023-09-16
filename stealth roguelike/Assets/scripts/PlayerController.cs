using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody2D rb;
    Vector2 input;
    private Vector2 mousePos;
    public Camera Camera;

    public SpriteRenderer spriteRenderer;
    public Sprite visible;
    public Sprite invisible;

    public bool isVisible = true;

    // Update is called once per frame
    // im a genius and thought that topdown movement was normally done with custom controller/physics cos its simple but its platformer
    void Update()
    {
        //vectors normallized so that the player doesnt move faster diagonally
        input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized;
        bool yuh = isVisible;
        if (Input.GetKeyDown("space"))
        {
            if (yuh == true)
            {
                spriteRenderer.sprite = invisible;
                isVisible = false;
                speed = 1f;
            } else
            {
                spriteRenderer.sprite = visible;
                isVisible = true;
                speed = 4f;
            }
        }

        //Player points towards mouse
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 perpendicular = (Vector2)transform.position - mousePos;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, perpendicular);
    }

    void FixedUpdate() {
        rb.velocity = input * speed;
    }
}

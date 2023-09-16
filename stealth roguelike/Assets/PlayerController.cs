using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    float xMove;
    float yMove;

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xMove, yMove, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFov : MonoBehaviour
{
    public float viewRadius = 5f;
    public float viewAngle;
    public Color normalColor;
    public Color targettedColor;
    public GameObject target;
    public SpriteRenderer sr;

    void Update() {
        bool visible = true;
        Vector2 dirToTarget = (Vector2)(target.transform.position - transform.position).normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dirToTarget);
        if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Walls")) {
            visible = false;
        }
        if ((target.transform.position - transform.position).magnitude > viewRadius) {
            visible = false;
        }

        if (Vector2.Angle(transform.right, dirToTarget) > viewAngle/2) {
            visible = false;
        }
        

        if (visible) {
            sr.color =  targettedColor;
        } else {
            sr.color = normalColor;
        }
    }
}

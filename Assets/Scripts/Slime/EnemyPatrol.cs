using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;
    public LayerMask groundLayers;

    public Transform groundCheck;

    private bool isFacingRight = true;

    private RaycastHit2D hit;

    private void Update()
    {
        hit = Physics2D.Raycast(groundCheck.position, -transform.up, 1f, groundLayers);
    }

    private void FixedUpdate() {
        if (hit.collider != false) {
            if (isFacingRight) {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            } else {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        } else
        {
            isFacingRight = !isFacingRight;
            transform.localScale = new Vector3(-transform.localScale.x, 1f, 1f);
        }
    }
}

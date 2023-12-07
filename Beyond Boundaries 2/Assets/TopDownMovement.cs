using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [Min(1), SerializeField] private float moveSpeed = 5.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal"), y = Input.GetAxisRaw("Vertical");

        rb.velocity = 100 * moveSpeed * Time.deltaTime * new Vector2(x, y);

    }
}

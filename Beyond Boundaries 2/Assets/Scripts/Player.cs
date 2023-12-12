using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    [Min(1), SerializeField] private float moveSpeed = 5.0f;
    public bool canMove = true;

    [Header("Sprites")]
    [Tooltip("Animations must be in this chronological order: facing to, left, right, and away from camera."), SerializeField] private Sprite[] playerSprites;

    //Internal Variables
    private Rigidbody2D rb;
    [HideInInspector] public bool isMoving;
    private SpriteRenderer spriteRenderer;
    private KeyCode fwd = KeyCode.W, bkwd = KeyCode.S, left = KeyCode.A, right = KeyCode.D;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (!canMove)
        {
            return;
        }

        spriteRenderer.sprite = Input.GetKeyDown(fwd) ? playerSprites[0]
            : Input.GetKeyDown(left) ? playerSprites[1]
            : Input.GetKeyDown(right) ? playerSprites[2]
            : Input.GetKeyDown(bkwd) ? playerSprites[3]
            : null;

        float x = Input.GetAxisRaw("Horizontal"), y = Input.GetAxisRaw("Vertical");

        Vector2 playerMovement = 100 * moveSpeed * Time.deltaTime * new Vector2(x, y);
        rb.velocity = playerMovement;
        isMoving = Mathf.Abs(x) > Mathf.Epsilon || Mathf.Abs(y) > Mathf.Epsilon;
    }
}

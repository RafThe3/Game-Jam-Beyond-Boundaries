using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Variables

    #region General
    //Internal Variables
    private Rigidbody2D rb;
    #endregion

    #region Movement
    [Header("Movement")]
    [Min(1), SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private bool canMove = true;

    //Internal Variables
    [HideInInspector] public bool isMoving;
    #endregion

    #endregion

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        #region Movement
        MovePlayer();
        #endregion
    }

    #region Methods

    #region Movement
    private void MovePlayer()
    {
        if (!canMove)
        {
            return;
        }

        float x = Input.GetAxisRaw("Horizontal"), y = Input.GetAxisRaw("Vertical");

        Vector2 playerMovement = 100 * moveSpeed * Time.deltaTime * new Vector2(x, y);
        rb.velocity = playerMovement;
        isMoving = Mathf.Abs(x) > Mathf.Epsilon || Mathf.Abs(y) > Mathf.Epsilon;
    }
    #endregion

    #endregion
}

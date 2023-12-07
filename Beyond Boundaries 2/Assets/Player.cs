using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region General
    //Internal Variables
    private Rigidbody2D rb;
    #endregion

    #region Movement
    [Header("Movement")]
    [Min(1), SerializeField] private float moveSpeed = 5.0f;
    #endregion

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        #region Movement
        float x = Input.GetAxisRaw("Horizontal"), y = Input.GetAxisRaw("Vertical");

        rb.velocity = 100 * moveSpeed * Time.deltaTime * new Vector2(x, y);
        #endregion
    }
}

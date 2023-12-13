using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    [Min(1) ,SerializeField] private float moveSpeed = 1f, chaseDistance = 1;
    public bool canMove = true;

    //Internal Variables
    private Rigidbody2D rb;
    private GameObject player;
    //private bool isMoving;
    //private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        //animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            MoveEnemy();
            FlipEnemyFacing();
        }
        else
        {
            rb.velocity = new(0, rb.velocity.y);
            return;
        }
    }

    private void Update()
    {
        //isMoving = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;
        //animator.SetBool("isMoving", isMoving);
    }

    private void MoveEnemy()
    {
        Vector3 playerPosition = player.transform.position - transform.position;
        bool playerIsClose = playerPosition.magnitude < chaseDistance;

        playerPosition.Normalize();
        Vector2 moveEnemy = 100 * moveSpeed * Time.deltaTime * new Vector2(x: playerPosition.x, y: playerPosition.y);
        rb.velocity = playerIsClose ? moveEnemy : Vector3.zero;
    }

    void FlipEnemyFacing()
    {
        bool horizontalSpeed = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;

        if (horizontalSpeed)
        {
            transform.localScale = new Vector3(Mathf.Sign(rb.velocity.x), 1, 1);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, chaseDistance);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

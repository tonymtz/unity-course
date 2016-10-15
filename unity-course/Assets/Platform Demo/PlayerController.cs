using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 7f;

    [SerializeField] private float jumpForce = 5f;

    [SerializeField] private float floorDistanceToleranceOnJump = 0.5f;

    private Rigidbody2D myRigidBody;


    private void Awake()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");

        if (horizontalAxis != 0)
        {
            myRigidBody.velocity = new Vector2(horizontalAxis*movementSpeed, myRigidBody.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
        }
    }

    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.down, Color.green, floorDistanceToleranceOnJump);
    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, floorDistanceToleranceOnJump);
        return hit.collider != null;
    }
}
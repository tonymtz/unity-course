using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;

    [SerializeField] private float movementSpeed = 3f;

    private Rigidbody2D myRigidbody2D;

    void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, jumpForce);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody2D.velocity = new Vector2(movementSpeed*-1, myRigidbody2D.velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody2D.velocity = new Vector2(movementSpeed, myRigidbody2D.velocity.y);
        }
    }
}
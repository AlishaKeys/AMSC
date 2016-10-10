using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private float speedPers = 1;
    private int direction = 1;

    private Animator _animator;
    public Animator animator { get { return _animator; } }

    private Rigidbody2D rb;

    public bool jump;

    void Start()
    {
        _animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Position();
    }


    void Position()
    {
        if (Input.GetKey(KeyCode.D))
        {
            // rb.gameObject.transform.localScale = new Vector3(1, 1, 1);

            _animator.SetBool("run", true);

            rb.velocity = new Vector2(direction * speedPers, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // rb.gameObject.transform.localScale = new Vector3(1, 1, 1);

            _animator.SetBool("run", true);

            rb.velocity = new Vector2(-direction * speedPers, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            if (jump)
            {
                _animator.SetBool("run", false);
                rb.velocity = new Vector2(rb.velocity.x, 3);
            }


        }
    }
}
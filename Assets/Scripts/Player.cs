using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private float speedPers = 1;
    private int direction = 1;

    public Animator _animator;
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
        if (Input.GetKey(KeyCode.D))
        {
            Right();
        }

        if (Input.GetKey(KeyCode.A))
        {
            Left();
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            Jump();
        }
    }


   public void Right ()
    {
        _animator.SetBool("run", true);

        rb.velocity = new Vector2(direction * speedPers, rb.velocity.y);

    }

            
    public void Left()
    {
            _animator.SetBool("run", true);

            rb.velocity = new Vector2(-direction * speedPers, rb.velocity.y);
    }
 
   public void Jump ()
    {
            if (jump)
            {
                _animator.SetBool("run", false);
                rb.velocity = new Vector2(rb.velocity.x, 3);
            }
    }
}
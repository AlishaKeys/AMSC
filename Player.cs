using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private float speedPers = 1;
    private int direction = 1;
    private int k = 4;

    public Animator _animator;
    public Animator animator { get { return _animator; } }

    private Rigidbody2D rb;

    public bool jump;

    public GameObject hp;
    private float x = -10.60381f;
    private GameObject [] array1;

    void Start()
    {
        _animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
        for (int i = 0; i < 5; i++)
        {
            float y = 4.373113f;
            GameObject newHp = Instantiate(hp);
            newHp.transform.position = new Vector2(x, y);
            x++;
            newHp.name = "HP" + i;
            array1 = new GameObject[5];
            array1[i] = newHp;
        }
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


    void OnTriggerStay2D(Collider2D target)
    {
        
            if (target.tag == "EnemyStrel")
        {
            LeanTween.color(gameObject, Color.red, 0.5f).onComplete = () => LeanTween.color(gameObject, Color.white, 0.5f);
            Destroy(array1[k]);
            //Destroy(this.gameObject);
        }

        
       

 
    }
}
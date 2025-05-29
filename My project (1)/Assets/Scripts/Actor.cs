using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{

    public string displayname;
    public float speedwalk;
    public Vector2 jumpForce;

    protected bool onfloor = false;
    protected SpriteRenderer sprRender;
    protected Animator animator;
    protected Rigidbody2D rigidBody;

    void Start()
    {
        sprRender = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 position = transform.position;
        bool moving = false;
         
         // Movimento para a frente 
        if (Input.GetKey(KeyCode.D))
        {
            moving = true;
            position.x += speedwalk * Time.deltaTime;
            sprRender.flipX = false;
        }

        // Movimento para trás
        else if(Input.GetKey(KeyCode.A))
        {
            moving = true;
            position.x -= speedwalk * Time.deltaTime;
            sprRender.flipX = true;
        }

        // Pulo 
        if(Input.GetKey(KeyCode.W) && onfloor == false)
        {
            rigidBody.AddForce(jumpForce);
            onfloor = true;
        }

        transform.position = position;

        // Troca de animação com base no movimento

        if (moving)
        {
            animator.CrossFade("walk", 0);
        }
        else
        {
            animator.CrossFade("stand", 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onfloor = false;
    }
}
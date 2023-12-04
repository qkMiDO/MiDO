using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float move = 0f;
    public float speed = 2f;
    public float Jump = 5f;
    public Rigidbody2D Rigidbody;
    public Transform transforme;
    public float radius;
    public LayerMask mask;
    private bool istouchingGround;
    Animator animator;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = gameObject.GetComponent("Rigidbody2D") as Rigidbody2D;
        animator = gameObject.GetComponent("Animator") as Animator;
        sprite = gameObject.GetComponent("SpriteRenderer") as SpriteRenderer;
    }

    // Update is called once per frame
    void Update()

    {

        istouchingGround = Physics2D.OverlapCircle(transforme.position, radius, mask);

        move = Input.GetAxis("Horizontal");
        //IDLE
        if (move == 0f)
        {
            Rigidbody.velocity = new Vector2(0, Rigidbody.velocity.y);
        }
        //RIGHT
        else if (move > 0)
        {
            Rigidbody.velocity = new Vector2(move * speed, Rigidbody.velocity.y);
            sprite.flipX = false;
        }
        //LEFT
        else
        {
            Rigidbody.velocity = new Vector2(move * speed, Rigidbody.velocity.y);
            sprite.flipX = true;
        }
        if (Input.GetButtonDown("Jump") && istouchingGround)
        {
            Rigidbody.velocity = new Vector2(Rigidbody.velocity.x, Jump + 1);
        }


        animator.SetFloat("SPEED", Mathf.Abs(Rigidbody.velocity.x));
        animator.SetBool("GROUND", istouchingGround);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator am;
    private SpriteRenderer sr;
    private BoxCollider2D bc;

    private float jalanX;

    private enum MovePlayer { idle, run, jump, fall }

    [SerializeField] private LayerMask jumpGround;
    [SerializeField] private AudioSource jumpSound;
    
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        jalanX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(jalanX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGround())
        {
            jumpSound.Play();
            rb.velocity = new Vector3(rb.velocity.x, 14f, 0);
        }

        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        MovePlayer state;

        if (jalanX > 0f)
        {
            state = MovePlayer.run;
            sr.flipX = false;
        }
        else if (jalanX < 0f)
        {
            state = MovePlayer.run;
            sr.flipX = true;
        }
        else
        {
            state = MovePlayer.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovePlayer.jump;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovePlayer.fall;
        }

        am.SetInteger("state", (int)state);
    }

    private bool IsGround()
    {
        return Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0f, Vector2.down, .1f, jumpGround);
    }
}

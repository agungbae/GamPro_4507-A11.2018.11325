using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator am;
    private Rigidbody2D rb;

    [SerializeField] private AudioSource deadSound;

    // Start is called before the first frame update
    private void Start()
    {
        am = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        deadSound.Play();
        am.SetTrigger("dead");
        rb.bodyType = RigidbodyType2D.Static;
    }

    private void Restartlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

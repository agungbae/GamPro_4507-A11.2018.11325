using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    public float bananas = 0;
    public float highScore = 0;

    [SerializeField] public Text bananasText;
    [SerializeField] public Text highScoreText;
    [SerializeField] public AudioSource collectItem;

    public void Start()
    {
        highScore = PlayerPrefs.GetFloat("Highscore");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Banana"))
        {
            collectItem.Play();
            Destroy(collision.gameObject);
            bananas++;
            bananasText.text = "Banana : " + bananas;
            
        }
        
    }

    public void Update()
    {
        
        //highScoreText.text = "Highscore : " + highScore;
        highScoreText.text = highScore.ToString();
        
        if(bananas > highScore)
        {
            PlayerPrefs.SetFloat("Highscore", bananas);
        }
    }
}

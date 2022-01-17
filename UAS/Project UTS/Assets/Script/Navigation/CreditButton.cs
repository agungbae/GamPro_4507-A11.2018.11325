using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButton : MonoBehaviour
{
    [SerializeField] private AudioSource buttonSound;

    public void Credit()
    {
        buttonSound.Play();
        SceneManager.LoadScene("Credit");
    }
}

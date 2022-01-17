using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButton : MonoBehaviour
{
    [SerializeField] private AudioSource buttonSound;

    public void Help()
    {
        buttonSound.Play();
        SceneManager.LoadScene("Help");
    }
}

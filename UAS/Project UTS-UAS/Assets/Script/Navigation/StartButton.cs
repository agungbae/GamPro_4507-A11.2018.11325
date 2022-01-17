using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    [SerializeField] private AudioSource buttonSound;

    public void Mulai()
    {
        buttonSound.Play();
        SceneManager.LoadScene("PilihStage");
    }
}

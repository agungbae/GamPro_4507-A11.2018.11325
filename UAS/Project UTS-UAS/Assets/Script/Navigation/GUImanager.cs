using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GUImanager : MonoBehaviour
{
    public void OnBack()
    {
        SceneManager.LoadScene ("Mulai");
    }

    public void OnStage1()
    {
        SceneManager.LoadScene ("Pepe 1");
    }

    public void OnStage2()
    {
        SceneManager.LoadScene ("Pepe 2");
    }

    public void OnStage3()
    {
        SceneManager.LoadScene ("Pepe 3");
    }

    public void OnStage4()
    {
        SceneManager.LoadScene ("Pepe 4");
    }
    /*public Button bStage1;
    public Button bStage2;
    public Button bStage3;
    public Button bStage4;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            LoadButtonStage();
            int levelstate = LoadStage();
            switch (levelstate)
            {
                case 0:
                    bStage1.interactable = true;
                    break;
                case 1:
                    bStage1.interactable = true;
                    bStage2.interactable = true;
                    break;
                case 2:
                    bStage1.interactable = true;
                    bStage2.interactable = true;
                    bStage3.interactable = true;
                    break;
                case 3:
                    bStage1.interactable = true;
                    bStage2.interactable = true;
                    bStage3.interactable = true;
                    bStage4.interactable = true;
                    break;
            }
        }
        catch(NullReferenceException e) {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    /*public static int LoadStage()
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey ("stage"))
            PlayerPrefs.SetInt ("stage" , 0);
        else
            hg = PlayerPrefs.GetInt ("stage");
        return hg;
    }

    public static void saveStage(int stg)
    {
        if (!PlayerPrefs.HasKey ("stage"))
            PlayerPrefs.SetInt ("stage" , 0);
        else
            PlayerPrefs.SetInt ("stage", stg);
    }

    void LoadButtonStage()
    {
        bStage1 = GameObject.Find ("Stage1").GetComponent<Button>();
        bStage2 = GameObject.Find ("Stage1").GetComponent<Button>();
        bStage3 = GameObject.Find ("Stage1").GetComponent<Button>();
        bStage4 = GameObject.Find ("Stage1").GetComponent<Button>();

        bStage1.interactable = bStage2.interactable = bStage3.interactable = bStage4.interactable = false;
    }*/
}

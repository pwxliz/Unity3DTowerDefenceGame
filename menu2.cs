﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu2 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource clickbutton;
    public void playmenu()
    {
        clickbutton.Play();
        SceneManager.LoadScene("levelmenu");
    }
    public void mainmenu()
    {
        clickbutton.Play();
        SceneManager.LoadScene("mainmenu");
    }
    public void quitmenu()
    {
        clickbutton.Play();
        Application.Quit();
    }
    public void level1()
    {
        clickbutton.Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    public void level2()
    {
        clickbutton.Play();
        SceneManager.LoadScene("map2");
    }
    public void level3()
    {
        clickbutton.Play();
        SceneManager.LoadScene("map3");
    }
    public void returnnew()
    {
        clickbutton.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}

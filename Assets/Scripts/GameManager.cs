﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int quantidadeDeBlocos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SairDoJogo();
        }
    }

    public void AumentarQuantidadeDeBlocos()
    {
        quantidadeDeBlocos += 1;
    }

    public void DiminuirQuantidadeDeBlocos()
    {
        quantidadeDeBlocos -= 1;

        if(quantidadeDeBlocos <= 0)
        {
            if(SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    private void SairDoJogo()
    {
        Application.Quit();
    }

}

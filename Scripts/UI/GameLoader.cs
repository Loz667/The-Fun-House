using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public GameObject gameFade;
    public Animator transistion;
    
    float transistionTime = 3f;

    public void LoadGame()
    {
        StartCoroutine(LoadingGame());
    }

    IEnumerator LoadingGame()
    {
        gameFade.SetActive(true);
        transistion.SetTrigger("Start");
        yield return new WaitForSeconds(transistionTime);
        gameFade.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject shootPlayer;
    public GameObject coconutPlayer;
    public GameObject duckPlayer;
    public GameObject molePlayer;
    public GameObject strengthPlayer;

    public Text winText;
    public Text gameText;

    private int shootHits = 0;
    private int moles = 0;

    private bool shootWin = false;
    private bool shyWin = false;
    private bool duckWin = false;
    private bool moleWin = false;
    private bool strWin = false;

    private float delayTime = 2;

    public void Start()
    {        
        //Destroy(gameText, delayTime);
    }

    public void ShootWin()
    {
        shootHits++;
        if (shootHits >= 10)
        {
            winText.text = "WINNER!";
            shootWin = true;
            Invoke("SwitchDelay", delayTime);
        }
    }

    public void ShyWin()
    {
        winText.text = "WINNER!";
        shyWin = true;
        Invoke("SwitchDelay", delayTime);
    }

    public void DuckWin()
    {
        winText.text = "WINNER!";
        duckWin = true;
        Invoke("SwitchDelay", delayTime);
    }

    public void MoleWin()
    {
        moles++;

        if (moles >= 10)
        {
            winText.text = "WINNER!";
            moleWin = true;
            Invoke("SwitchDelay", delayTime);
        }
    }

    public void StrengthWin()
    {
        winText.text = "WINNER!";
        strWin = true;
        Invoke("SwitchDelay", delayTime);
    }

    void SwitchDelay()
    {
        if (shootWin == true)
        {
            shootPlayer.SetActive(!shootPlayer.activeInHierarchy);
            mainPlayer.SetActive(!shootPlayer.activeInHierarchy);
            winText.text = "";
            gameText.text = "";
        }

        if (shyWin == true)
        {
            coconutPlayer.SetActive(!coconutPlayer.activeInHierarchy);
            mainPlayer.SetActive(!coconutPlayer.activeInHierarchy);
            winText.text = "";
            gameText.text = "";
        }

        if (duckWin == true)
        {
            duckPlayer.SetActive(!duckPlayer.activeInHierarchy);
            mainPlayer.SetActive(!duckPlayer.activeInHierarchy);
            winText.text = "";
            gameText.text = "";
        }

        if (moleWin == true)
        {
            molePlayer.SetActive(!molePlayer.activeInHierarchy);
            mainPlayer.SetActive(!molePlayer.activeInHierarchy);
            winText.text = "";
        }

        if (strWin == true)
        {
            strengthPlayer.SetActive(!strengthPlayer.activeInHierarchy);
            mainPlayer.SetActive(!strengthPlayer.activeInHierarchy);
            winText.text = "";
            gameText.text = "";
        }
    }
}

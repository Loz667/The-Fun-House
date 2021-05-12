using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StrengthInteraction : MonoBehaviour
{
    [SerializeField] GameObject gameLoader;
    [SerializeField] GameObject strTest;
    public GameObject mainPlayer;
    public GameObject strengthPlayer;
    public GameObject interact;

    public Text gameText;

    public bool strengthtest;

    // UI Popup
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(true);
            strengthtest = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(false);
            strengthtest = false;
        }
    }

    // Can play game check
    void Update()
    {
        if (strengthtest == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Started Strength Test");
            strengthtest = false;
            interact.SetActive(false);
            strTest.GetComponent<StrengthTest>().GameStart();
            mainPlayer.SetActive(!mainPlayer.activeInHierarchy);
            strengthPlayer.SetActive(!mainPlayer.activeInHierarchy);
            gameLoader.GetComponent<GameLoader>().LoadGame();
            gameText.text = "Use Left Mouse Button to hit the plunger";
        }
    }
}


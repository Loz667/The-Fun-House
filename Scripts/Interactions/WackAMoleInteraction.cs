using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WackAMoleInteraction : MonoBehaviour
{
    [SerializeField] GameObject gameLoader;
    public GameObject mainPlayer;
    public GameObject molePlayer;
    public GameObject interact;

    public Text gameText;

    public bool WackAMole;

    // UI Popup
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(true);
            WackAMole = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(false);
            WackAMole = false;
        }
    }

    // Can play game check
    void Update()
    {
        if (WackAMole == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Started WackAMole Game");
            WackAMole = false;
            interact.SetActive(false);
            mainPlayer.SetActive(!mainPlayer.activeInHierarchy);
            molePlayer.SetActive(!molePlayer.activeInHierarchy);
            gameLoader.GetComponent<GameLoader>().LoadGame();
            gameText.text = "Use Left Mouse Button to hit the moles";
        }
    }
}
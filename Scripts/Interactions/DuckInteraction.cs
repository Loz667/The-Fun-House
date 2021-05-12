using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DuckInteraction : MonoBehaviour
{
    [SerializeField] GameObject gameLoader;
    public GameObject mainPlayer;
    public GameObject duckPlayer;
    public GameObject interact;

    public Text gameText;

    public bool HookADuck;

    // UI Popup
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(true);
            HookADuck = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(false);
            HookADuck = false;
        }
    }

    // Can play game check
    void Update()
    {
        if (HookADuck == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Started HookADuck");
            HookADuck = false;
            interact.SetActive(false);
            mainPlayer.SetActive(!mainPlayer.activeInHierarchy);
            duckPlayer.SetActive(!duckPlayer.activeInHierarchy);
            gameLoader.GetComponent<GameLoader>().LoadGame();
            gameText.text = "Use Left Mouse Button to hook a duck";

        }
    }
}


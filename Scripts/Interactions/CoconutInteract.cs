using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoconutInteract : MonoBehaviour
{
    [SerializeField] GameObject gameLoader;
    public GameObject mainPlayer;
    public GameObject coconutPlayer;
    public GameObject interact;

    public Text gameText;

    public bool coconutshy;    

    // UI Popup
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(true);
            coconutshy = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(false);
            coconutshy = false;
        }
    }

    // Can play game check
    void Update()
    {
        if (coconutshy == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Started Coconut Shy");
            coconutshy = false;
            interact.SetActive(false);
            mainPlayer.SetActive(!mainPlayer.activeInHierarchy);
            coconutPlayer.SetActive(!coconutPlayer.activeInHierarchy);
            gameLoader.GetComponent<GameLoader>().LoadGame();
            gameText.text = "Use Left Mouse Button to throw a ball";
        }

    }
}


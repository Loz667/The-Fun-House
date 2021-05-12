using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LadderInteract : MonoBehaviour
{
    [SerializeField] GameObject gameLoader;
    public GameObject interact;
    public GameObject mainPlayer;
    public GameObject ladderPlayer;

    public Text gameText;

    public bool ladder;

    // UI Popup
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(true);
            ladder = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(false);
            ladder = false;
        }
    }

    // Can play game check
    void Update()
    {
        if (ladder == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Started Ladder Balance");
            ladder = false;
            interact.SetActive(false);
            mainPlayer.SetActive(!mainPlayer.activeInHierarchy);
            ladderPlayer.SetActive(!ladderPlayer.activeInHierarchy);
            gameLoader.GetComponent<GameLoader>().LoadGame();
            gameText.text = "Use Q and E keys to keep your balance";
        }
    }
}

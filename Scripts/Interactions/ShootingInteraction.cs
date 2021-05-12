using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShootingInteraction : MonoBehaviour
{
    [SerializeField] GameObject gameLoader;

    public GameObject mainPlayer;
    public GameObject shootingPlayer;
    public GameObject interact;

    public Text gameText;

    public bool shooting;

    // UI Popup
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(true);
            shooting = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact.SetActive(false);
            shooting = false;
        }
    }

    // Can play game check
    void Update()
    {
        if (shooting == true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Started Shooting Game");
            shooting = false;
            interact.SetActive(false);
            mainPlayer.SetActive(!mainPlayer.activeInHierarchy);
            shootingPlayer.SetActive(!shootingPlayer.activeInHierarchy);
            gameLoader.GetComponent<GameLoader>().LoadGame();
            gameText.text = "Use Left Mouse Button to fire rifle";
        }
    }
}

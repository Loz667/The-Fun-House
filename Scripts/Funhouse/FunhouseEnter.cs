using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FunhouseEnter : MonoBehaviour
{
  //  public Image Funhousebackground;
  //  public Text FunhouseInteractText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Dream Level");
            // Entering funhouse will either be - new scene - teleporting to a different "cell"
            // SceneManager.LoadScene("Funhouse")
            // gameObject.transform.position = new Vector3(Random.Range (-10.0f, 10.0f ), gameObject.transform.position.y, Random.Range(-10.0f, 10.0f));
        }
    }
}




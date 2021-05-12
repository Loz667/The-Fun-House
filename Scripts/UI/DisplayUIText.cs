using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayUIText : MonoBehaviour
{
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string messageToDisplay;

    private void Awake()
    {
        dialogBox.SetActive(false);
    }

    void Start()
    {
        
        //TextWriter.AddWriter_Static(dialogText, "Control, I have arrived at the abandoned fairground.\nBeginning preliminary search of the site.", .1f, true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogBox.SetActive(true);
            dialogText.text = messageToDisplay;
            StartCoroutine(RemoveAfterSeconds(5, dialogBox));
        }
    }

    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
}

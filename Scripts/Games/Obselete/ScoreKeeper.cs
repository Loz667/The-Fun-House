using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    public Text winText;

    private float delayTime;

    private int targets;
    
    public void ScoreUp()
    {
        targets++;

        if (targets >= 5)
        {
            winText.text = "WINNER!";
            Invoke("SwitchDelay", delayTime);
        }
    }

    void SwitchDelay()
    {
        SceneManager.LoadScene("Level");
    }
}

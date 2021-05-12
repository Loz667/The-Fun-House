using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellCollision : MonoBehaviour
{
    [HideInInspector] public bool beenHit;

    //[SerializeField] AudioClip bellSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (beenHit == false && collision.gameObject.name == "Striker")
        {
            Debug.Log("Bell ringing");
            //audio.PlayOneShot(bellSound);
            beenHit = true;
            GameObject.Find("Game Manager").GetComponent<GameManager>().StrengthWin();
        }
        else
        {
            beenHit = false;
        }
    }
}

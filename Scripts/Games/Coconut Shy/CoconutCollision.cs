using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutCollision : MonoBehaviour
{
    Rigidbody myRB;
    bool beenHit = false;

    public AudioSource CoconutHit;
    //AudioSource _audio;
    //public AudioClip hitSound;

    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        CoconutHit = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (beenHit == false && collision.gameObject.name == "Ball")
        {
            beenHit = true;
            GameObject.Find("Game Manager").GetComponent<GameManager>().ShyWin();
            CoconutHit.Play();
            //_audio.PlayOneShot(hitSound);
            myRB.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            Destroy(gameObject, 1);
        }
    }
}

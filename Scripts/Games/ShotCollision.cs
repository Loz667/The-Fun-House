using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCollision : MonoBehaviour
{
    public GameObject targetRoot;

    private bool beenHit = false;
    private float timer = 0.0f;

    public AudioSource TargetHit;
    //[SerializeField] AudioClip hitSound;
    //[SerializeField] AudioClip resetSound;


    void Start()
    {
        TargetHit = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (beenHit == false && collision.gameObject.name == "Shot")
        {
            //audio.PlayOneShot(hitSound);
            targetRoot.GetComponent<Animation>().Play("TargetDown");
            GameObject.Find("Game Manager").GetComponent<GameManager>().ShootWin();
            beenHit = true;
            TargetHit.Play();
        }
    }

    void Update()
    {
        if (beenHit)
        {
            timer += Time.deltaTime;
        }

        if (timer > 1)
        {
            //audio.PlayOneShot(resetSound);
            targetRoot.GetComponent<Animation>().Play("TargetUp");
            beenHit = false;
            timer = 0.0f;
        }
    }
}

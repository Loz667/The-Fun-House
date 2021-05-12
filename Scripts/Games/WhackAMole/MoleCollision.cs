using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleCollision : MonoBehaviour
{
    [HideInInspector] public Animator anim;
    Collider col;

    bool beenHit = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        col = GetComponent<Collider>();
        col.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (beenHit == false && collision.gameObject.name == "hammer")
        {
            beenHit = true;
        }
    }

    void Update()
    {
        if (beenHit)
        {
             beenHit = false;
        }
    }

    public void SwitchCollider(int num)
    {
        col.enabled = (num == 0) ? false : true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public Animator hammer;

    [SerializeField] private Camera FPCam;
    [SerializeField] private float range = 50f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            HitMole();
            hammer.SetTrigger("Hit");
        }
    }

    private void HitMole()
    {
        Ray ray = FPCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, range))
        {            
            if (hit.collider.CompareTag("Mole"))
            {
                Debug.Log("Hit " + hit.transform.name);

                GameObject.Find("Game Manager").GetComponent<GameManager>().MoleWin();
                MoleCollision mole = hit.collider.gameObject.GetComponent<MoleCollision>();
                mole.SwitchCollider(0);
                mole.anim.SetTrigger("Hit");
            }
        }
    }
}

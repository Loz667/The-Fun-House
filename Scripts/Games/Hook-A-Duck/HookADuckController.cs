using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HookADuckController : MonoBehaviour
{
    public Animator anim;

    [SerializeField] private Camera FPCam;
    [SerializeField] private float range = 100f;
    //[HideInInspector] public bool hasHooked = false;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Hook();
            anim.SetTrigger("Hook");
        }
    }

    private void Hook()
    {
        Ray ray = FPCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, range))
        {
            if (hit.collider.CompareTag("Duck"))
            {
                Debug.Log("Hit " + hit.transform.name);
                //hasHooked = true;
            }
        }
        /*RaycastHit hit;

        if (Physics.Raycast(FPCam.transform.position, FPCam.transform.forward, out hit, range))
        {
            Debug.Log("Hit " + hit.transform.name);

            GameObject.Find("Game Manager").GetComponent<GameManager>().DuckWin();

            hasHooked = true;
        }*/
    }
}

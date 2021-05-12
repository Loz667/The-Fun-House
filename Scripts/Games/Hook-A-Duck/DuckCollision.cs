using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckCollision : MonoBehaviour
{
    [HideInInspector] public HookADuckController had;
    [HideInInspector] public bool beenHooked;
    [SerializeField] GameObject duck;

    private void OnCollisionEnter(Collision collision)
    {
        if (beenHooked == false && collision.gameObject.name == "Fishing Pole")
        {
            beenHooked = true;
        }
    }

    void Update()
    {
        if (beenHooked)
        {
            beenHooked = false;
            duck.SetActive(true);
            GameObject.Find("Game Manager").GetComponent<GameManager>().DuckWin();
        }

    }
}

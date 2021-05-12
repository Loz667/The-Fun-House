using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleTrigger : MonoBehaviour
{
    public GameObject[] moles;

    void Start()
    {
        Invoke("TriggerMole", Random.Range(1f, 4f));
    }

    void TriggerMole()
    {
        int num = Random.Range(0, moles.Length);

        GameObject mole = moles[num];

        mole.GetComponent<Animator>().SetTrigger("Up");

        Invoke("TriggerMole", Random.Range(1f, 4f));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TidyUp : MonoBehaviour
{
    void Start()
    {
        //Will destroy object where script is attached after set time
        Destroy(gameObject, 1);
    }
}

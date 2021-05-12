using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] GameObject loader;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loader.GetComponent<LevelLoader>().LoadLevel();
        }
    }
}

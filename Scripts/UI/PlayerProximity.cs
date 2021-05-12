using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProximity : MonoBehaviour
{
    Light myLight;

    float dist;
    
    public Transform player;

    void Awake()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (player)
        {
            dist = Vector3.Distance(transform.position, player.position);
        }
        //Debug.Log("Distance to player: " + dist);

        ChangingRange();
    }

    void ChangingRange()
    {
        if (dist < 20)
        {
            float pctDistance = dist / 10;
            myLight.range = Mathf.Lerp(pctDistance, 10f, 1f);
        }
        else if (dist > 20)
        {
            myLight.range = 0;
        }
    }
}

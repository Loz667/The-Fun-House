using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DuckMovement : MonoBehaviour
{
    public GameObject target;
    public float _speed;

    private float myYaxis;
    public float bobStrength = .5f;

    private void Start()
    {
        myYaxis = this.transform.position.y;
    }

    void Update()
    {
        DuckRotate();
        DuckBobbing();
    }

    void DuckRotate()
    {
        transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * _speed);
    }

    void DuckBobbing()
    {
        transform.position = new Vector3 (transform.position.x, myYaxis + ((float)Mathf.Sin(Time.time) * bobStrength), transform.position.z);
    }
}

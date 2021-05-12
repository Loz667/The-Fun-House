using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public Rigidbody ballPrefab;

    public float throwForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ThrowBall();
    }

    void ThrowBall()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Rigidbody newBall = Instantiate(ballPrefab, transform.position, transform.rotation);
            newBall.name = "Ball";
            newBall.velocity = transform.TransformDirection(new Vector3(0, 0, throwForce));
            Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newBall.GetComponent<Collider>(), true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Rigidbody shotPrefab;
    public float shotForce;

    [SerializeField] private Camera FPCam;

    public AudioSource RifleShot;

    //[SerializeField] private float range = 100f;
    //[SerializeField] private float damage = 10f;

    // Start is called before the first frame update
    void Start()
    {
        RifleShot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            RifleShot.Play();
        }
    }

    private void Shoot()
    {
        Rigidbody newShot = Instantiate(shotPrefab, transform.position, transform.rotation);
        newShot.name = "Shot";
        newShot.velocity = transform.TransformDirection(0, 0, shotForce);
        //Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newShot.GetComponent<Collider>(), true);

        /*RaycastHit hit;

        if (Physics.Raycast(FPCam.transform.position, FPCam.transform.forward, out hit, range))
        {
            //Debug.Log("Hit " + hit.transform.name);            

            TargetHealth target = hit.transform.GetComponent<TargetHealth>();
            target.TakeDamage(damage);
            GameObject.Find("Spawn Manager").GetComponent<ScoreKeeper>().ScoreUp();
        }
        else
        {
            return;
        }*/
    }
}

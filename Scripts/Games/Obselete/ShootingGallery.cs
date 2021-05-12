using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShootingGallery : MonoBehaviour
{
    public GameObject targetPrefab;
    public GameObject gameText;

    public float secondsBetweenSpawn;
    private float elapsedTime = 0f;
    private float delayTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameText, delayTime);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;
            SpawnNewTarget();
        }

       
    }

    private Vector3 GenerateTargetPosition()
    {
        float spawnPosY = Random.Range(1.125f, 3);
        float spawnPosZ = Random.Range(-2.25f, 2.25f);
        Vector3 randomPos = new Vector3(10, spawnPosY, spawnPosZ);
        return randomPos;        
    }

    void SpawnNewTarget()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(targetPrefab, GenerateTargetPosition(), targetPrefab.transform.rotation);
        }
    }
}




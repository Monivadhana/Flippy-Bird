using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    [SerializeField]GameObject pipePrefab;
    [SerializeField] Transform pipeHolder;
    [SerializeField] float spawnInterval = 1f;
    [SerializeField] float spawnHeight;
    private float spawnTimerDelta;
    public static float spawnSpeedMultiplier = 1f;

    private Transform transform;
    
    private void Start()
    {
        transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if(spawnTimerDelta <= 0f)
        {
            Vector3 pos = transform.position + new Vector3(0f, Random.Range(-spawnHeight, spawnHeight), 0f);
            Spawn(pos);
            spawnTimerDelta = spawnInterval * (1 / spawnSpeedMultiplier);
        }
        spawnTimerDelta -= Time.deltaTime;
    }
    void Spawn(Vector3 position)
    {
        GameObject pipe = Instantiate(pipePrefab,position,Quaternion.identity, pipeHolder);
        Destroy(pipe,10f);
    }
}

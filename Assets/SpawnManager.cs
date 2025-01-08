using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public gameObject enemyPrefab
    private float spwanRange = 9;
    // Start is called before the first frame update
    void Start()
    {
        
        instantiate(enemyPrefab, new Vector3(0, 0, 6),
        enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 generateSpawnPosition (){
        float spwanPosX = Random.Range(-spwanRange, spwanRange);
        float spwanPosZ = Random.Range(-spwanRange, spwanRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spwanPosZ);
    }

}

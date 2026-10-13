using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyToSpawn;

    private float[] columns = { -4.5f, -3.5f, -2.5f, -1.5f, -0.5f, 
        0.5f, 1.5f, 2.5f, 3.5f, 4.5f};
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        int selectedColumn = Random.Range(0, columns.Length);
        Instantiate(enemyToSpawn, new Vector2(columns[selectedColumn], 4.5f), enemyToSpawn.transform.rotation);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

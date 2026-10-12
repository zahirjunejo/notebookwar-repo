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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

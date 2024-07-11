using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    
    public GameObject[] enemyPrefab;
    float time;
    public int _stage = 0;
    

    void Awake()
    {
        
    }

    void Update()
    {
        
    }

    public IEnumerator Spawn()
    {
        for(int i = 0; i <= 5; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab[_stage]);
            enemy.transform.parent = transform;
            enemy.transform.position = transform.position;
            enemy.transform.rotation = transform.rotation;
            yield return new WaitForSeconds(1);
        }
        _stage++;
       
    }
}

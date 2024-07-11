using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int poolSize = 10;

    private List<GameObject> pool;
    // Start is called before the first frame update
    void Start()
    {
        pool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab);

            pool.Add(enemyPrefab);
        }
    }

    public GameObject GetPooledObject()
    {
        foreach (GameObject enemyPrefab in pool)
        {
            if (!enemyPrefab.activeInHierarchy)
            {
                return enemyPrefab;
            }
        }

        GameObject newEnemy = Instantiate(enemyPrefab);

        newEnemy.SetActive(false);
        pool.Add(newEnemy);

        return newEnemy;
    }
}

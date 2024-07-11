using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject[] bulletPrefab;
    public int poolSize = 10;

    private List<GameObject> pool;
    // Start is called before the first frame update
    void Awake()
    {
        pool = new List<GameObject>();

        for(int i = 0; i < poolSize; i++)
        {
         
            
            GameObject sword_Attack = Instantiate(bulletPrefab[0]);
            GameObject acher_Attack = Instantiate(bulletPrefab[1]);
            GameObject wizard_Attack = Instantiate(bulletPrefab[2]);


            sword_Attack.transform.parent = transform;
            sword_Attack.SetActive(false);
            pool.Add(sword_Attack);

            acher_Attack.transform.parent = transform;
            acher_Attack.SetActive(false);
            pool.Add(acher_Attack);

            wizard_Attack.transform.parent = transform;
            wizard_Attack.SetActive(false);
            pool.Add(wizard_Attack);

        }
    }

    public GameObject GetPooledObject()
    {
        foreach(GameObject bullet in pool)
        {
            if (!bullet.activeInHierarchy)
            {
                return bullet;
            }
        }
        /*
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.parent = transform;

        newBullet.SetActive(false);
        pool.Add(newBullet);

        return newBullet;
        */
        return null;
    }
}

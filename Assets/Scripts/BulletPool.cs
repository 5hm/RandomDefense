using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public GameObject _swordBulletPreFab;
    public GameObject _archerBulletPreFab;
    public GameObject _wizardBulletPreFab;

    public int test = 10;

    int _poolSize = 30;

    private List<GameObject> _bulletPool;
    void Awake()
    {
        _bulletPool = new List<GameObject>();
        Generate();
    }

    void Generate()
    {
        for(int i = 0; i <= _poolSize; i++)
        {
            GameObject _swordBullet = Instantiate(_swordBulletPreFab, transform);
            GameObject _archerBullet = Instantiate(_archerBulletPreFab, transform);
            GameObject _wizardBullet = Instantiate(_wizardBulletPreFab, transform);

            _bulletPool.Add(_swordBullet);
            _bulletPool.Add(_archerBullet);
            _bulletPool.Add(_wizardBullet);

            _swordBullet.SetActive(false);
            _archerBullet.SetActive(false);
            _wizardBullet.SetActive(false);

        }
    }

    public GameObject GetBulletObject(string name) {
        if(name == "Unit_Sword(Clone)")
        {
            foreach (GameObject bullet in _bulletPool)
            {

                if (bullet.name == "Bullet_Sword(Clone)" && !bullet.activeInHierarchy)
                {
                    return bullet;
                }

            }
            GameObject newBullet = Instantiate(_swordBulletPreFab);
            newBullet.transform.parent = transform;

            newBullet.SetActive(false);
            _bulletPool.Add(newBullet);

            return newBullet;

        }
        else if (name == "Unit_Archer(Clone)")
        {
            foreach (GameObject bullet in _bulletPool)
            {

                if (bullet.name == "Bullet_Archer(Clone)" && !bullet.activeInHierarchy)
                {
                    return bullet;
                }

            }

            GameObject newBullet = Instantiate(_archerBulletPreFab);
            newBullet.transform.parent = transform;

            newBullet.SetActive(false);
            _bulletPool.Add(newBullet);

            return newBullet;
        }
        else if (name == "Unit_Wizard(Clone)")
        {
            foreach (GameObject bullet in _bulletPool)
            {

                if (bullet.name == "Bullet_Wizard(Clone)" && !bullet.activeInHierarchy)
                {
                    return bullet;
                }

            }

            GameObject newBullet = Instantiate(_wizardBulletPreFab);
            newBullet.transform.parent = transform;

            newBullet.SetActive(false);
            _bulletPool.Add(newBullet);

            return newBullet;
        }
        return null;
    }
}

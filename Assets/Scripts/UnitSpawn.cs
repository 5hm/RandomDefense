using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawn : MonoBehaviour
{
    public GameObject _swordPrefab;
    public GameObject _archerPrefab;
    public GameObject _wizardPrefab;

    public UnitSpawnPoint _unitSpawnPoint;
    public GameObject[] _spawnPoint;

    private List<GameObject> _unitPool;

    int poolSize = 30;

    void Awake()
    {
        _unitPool = new List<GameObject>();
       

        Generate();
    }

    void Generate()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject _sword = Instantiate(_swordPrefab, transform);
            GameObject _archer = Instantiate(_archerPrefab, transform);
            GameObject _wizard = Instantiate(_wizardPrefab, transform);


            _sword.SetActive(false);
            _archer.SetActive(false);
            _wizard.SetActive(false);

            _unitPool.Add(_sword);
            _unitPool.Add(_archer);
            _unitPool.Add(_wizard);
        }
    }

    public void Draw1()
    {
        int ran = Random.Range(1, 101);
        foreach (GameObject summonUnit in _unitPool)
        {
            if (ran > 0 && ran <= 80)
            {
                if (!summonUnit.activeInHierarchy && summonUnit.name == "Unit_Sword(Clone)")
                {
                    for(int i=0; i<=_spawnPoint.Length; i++)
                    {
                        if (_spawnPoint[i].GetComponent<UnitSpawnPoint>()._unitSpawnPointCheck)
                        {
                            Debug.Log(ran + summonUnit.name);
                            summonUnit.transform.position = _spawnPoint[i].transform.position;
                            _spawnPoint[i].GetComponent<UnitSpawnPoint>()._unitSpawnPointCheck = false;
                            Debug.Log(_spawnPoint[i]);
                            summonUnit.SetActive(true);
                            break;
                        }
                    }
                 
                }
            }

            else if (ran > 80 && ran <= 99)
            {
                if (!summonUnit.activeInHierarchy && summonUnit.name == "Unit_Archer(Clone)")
                {
                    Debug.Log(ran + summonUnit.name);
                    summonUnit.SetActive(true);
                    break;
                }
            }

            else
            {
                if (!summonUnit.activeInHierarchy && summonUnit.name == "Unit_Wizard(Clone)")
                {
                    Debug.Log(ran + summonUnit.name);
                    summonUnit.SetActive(true);
                    break;
                }
            }
        }

    }

    public void Draw2()
    {
        int ran = Random.Range(1, 101);
        foreach (GameObject summonUnit in _unitPool)
        {
            if (ran > 0 && ran <= 60)
            {
                if (!summonUnit.activeInHierarchy && summonUnit.name == "Unit_Sword(Clone)")
                {
                    Debug.Log(ran + summonUnit.name);
                    summonUnit.SetActive(true);
                    break;
                }
            }

            else if (ran > 60 && ran <= 95)
            {
                if (!summonUnit.activeInHierarchy && summonUnit.name == "Unit_Archer(Clone)")
                {
                    Debug.Log(ran + summonUnit.name);
                    summonUnit.SetActive(true);
                    break;
                }
            }

            else
            {
                if (!summonUnit.activeInHierarchy && summonUnit.name == "Unit_Wizard(Clone)")
                {
                    Debug.Log(ran + summonUnit.name);
                    summonUnit.SetActive(true);
                    break;
                }
            }
        }

    }

    public void Draw3()
    {
        int ran = Random.Range(1, 101);
        foreach (GameObject summonUnit in _unitPool)
        {
            if (ran > 0 && ran <= 30)
            {
                if (!summonUnit.activeInHierarchy && summonUnit.name == "Unit_Sword(Clone)")
                {
                    Debug.Log(ran + summonUnit.name);
                    summonUnit.SetActive(true);
                    break;
                }
            }

            else if (ran > 30 && ran <= 90)
            {
                if (!summonUnit.activeInHierarchy && summonUnit.name == "Unit_Archer(Clone)")
                {
                    Debug.Log(ran + summonUnit.name);
                    summonUnit.SetActive(true);
                    break;
                }
            }

            else
            {
                if (!summonUnit.activeInHierarchy && summonUnit.name == "Unit_Wizard(Clone)")
                {
                    Debug.Log(ran + summonUnit.name);
                    summonUnit.SetActive(true);
                    break;
                }
            }
        }

    }
}

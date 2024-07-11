using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum InfoType {EnemyCount, UnitCount, Money, Time}
    public InfoType type;
    public EnemySpawn _enemySpawn;

    Text myText;
    public float setTime;
    public float bossTime;


    void Awake()
    {
        myText = GetComponent<Text>();
    }

    void Update()
    {
        switch(type)
        {
            case InfoType.EnemyCount:
                break;
            case InfoType.UnitCount:
                break;
            case InfoType.Money:
                break;
            case InfoType.Time:
                if(setTime >= 0)
                {
                    setTime -= Time.deltaTime;
                    int min = Mathf.FloorToInt(setTime / 60);
                    int sec = Mathf.FloorToInt(setTime % 60);
                    myText.text = string.Format("{0:D2}:{1:D2}", min, sec);

                }
                else
                {

                    StartCoroutine(_enemySpawn.Spawn());
                    setTime = 30f;
                }
                
                break;
        }
    }

   
}

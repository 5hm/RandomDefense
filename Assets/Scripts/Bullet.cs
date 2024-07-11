using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    
    public float _speed;
    public float _dmg;
    Rigidbody2D _rigid;
    Collider2D _col;
    Vector3 _dirVec;
       

    // Start is called before the first frame update
    void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _col = GetComponent<Collider2D>();
    }

    public void SetDirection(Vector3 dirVec)
    {
        _dirVec = dirVec;
    }

    // Update is called once per frame
    void Update()
    {
        _rigid.velocity = _dirVec.normalized * _speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || collision.CompareTag("Border"))
        {
            gameObject.SetActive(false);
        }
    }

}

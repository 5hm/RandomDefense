using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    Collider2D _coll;
    Animator _anim;
    public bool _attack = false;
    Scanner _scanner;
    SpriteRenderer _sprite;


    // Start is called before the first frame update
    void Start()
    {
        _coll = GetComponent<Collider2D>();
        _anim = GetComponent<Animator>();
        _scanner = GetComponent<Scanner>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(_scanner.nearestTarget != null && _attack == false)
        {
            
            Attack();
        }    
       
       if(_scanner.nearestTarget == null && _attack == true)
        {
            StopAttack();
        }

    }

    void Attack()
    {
        Shoot();
        _attack = true;
        _anim.SetBool("Attack", true);
    }

    void StopAttack()
    {
        _attack = false;
        _anim.SetBool("Attack", false);
    }

    void Shoot()
    {
        string name = gameObject.name;
        GameObject bulletPool = GameObject.Find("BulletPool");

        GameObject bullet = bulletPool.GetComponent<BulletPool>().GetBulletObject(name);
        
        if (bullet != null && _scanner.nearestTarget)
        {
            //방향벡터(directional vector)
            Vector3 dirVec = _scanner.nearestTarget.position - transform.position;


            bullet.transform.rotation.SetLookRotation(dirVec);
            bullet.GetComponent<Bullet>().SetDirection(dirVec);

            bullet.transform.position = transform.position;
            //bullet.transform.rotation = transform.rotation;

            bullet.SetActive(true);
        }
        
    }


    // 여긴 신경 안쓰셔도 됩니당
    /*
    void Shoot()
    {
        
        GameObject bullet = _objectPool.GetPooledObject();

        if (bullet != null && _scanner.nearestTarget)
        {
            //방향벡터(directional vector)
            Vector3 dirVec = _scanner.nearestTarget.position - transform.position;
           
            
            bullet.transform.rotation.SetLookRotation(dirVec);
            bullet.GetComponent<Bullet>().SetDirection(dirVec);

            bullet.transform.position = transform.position;
            //bullet.transform.rotation = transform.rotation;

            bullet.SetActive(true);

        }
    }
    */
}

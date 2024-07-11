using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rigid;
    Collider2D coll;
    SpriteRenderer spriter;
    Animator anim;
    public Bullet bullet;

    public float speed;
    public int moveH;
    public int moveV;
    bool isLive = true;

    public float health;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isLive) { rigid.velocity = new Vector2(moveH, moveV) * speed; }
       

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Check"))
        {
            switch (collision.gameObject.name)
            {
                case "Down":
                    moveH = 0;
                    moveV = -1;
                    spriter.flipX = true;
                    break;
                case "Left":
                    moveH = -1;
                    moveV = 0;
                    break;
                case "Up":
                    moveH = 0;
                    moveV = 1;
                    spriter.flipX = false;
                    break;
                case "Right":
                    moveH = 1;
                    moveV = 0;
                    break;
            }                       
        }
        if (collision.CompareTag("Bullet"))
        {
            OnHit(bullet._dmg);
        }
    }

    void OnHit(float dmg)
    {
        health -= dmg;
        spriter.color = new Color(1, 1, 1, 0.4f);
        Invoke("ReturnSprite", 0.1f);

        if(health <= 0)
        {
            isLive = false;
            coll.enabled = false;
            rigid.simulated = false;
            spriter.sortingOrder = 3;
            anim.SetBool("Die", true);
        }
        
    }

    void ReturnSprite()
    {
        spriter.color = new Color(1, 1, 1, 1);
    }
    
    void Dead()
    {
        Destroy(gameObject);
    }
}

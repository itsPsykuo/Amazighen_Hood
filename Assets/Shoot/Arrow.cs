using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10f;
    public int damage = 50;

    public GameObject shootEffect;
    public GameObject impactEffect;

    void Awake()
    {
            rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Rabbit rabbit = hitInfo.GetComponent<Rabbit>();
        if (rabbit != null)
        {
            rabbit.TakeDamage(damage);
            Instantiate(shootEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (hitInfo.CompareTag("Ground"))
        {
            Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        Devil boss = hitInfo.GetComponent<Devil>();
        if (boss != null)
        {
            boss.TakeDamageBoss(damage);
            Instantiate(shootEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}

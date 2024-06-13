using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    public int health = 100;

    public float speed = 2f;

    public static Rabbit instance;
    private static Rabbit Instance;

    public GameObject pointA;
    public GameObject pointB;
    public Rigidbody2D rb;
    private Transform currentPoint;

    void Start()
    {
        currentPoint = pointB.transform;
    }

    private void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2 (speed, 0f);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0f);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            flip();
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            flip();
            currentPoint = pointB.transform;
        }
    }

    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);

    }

    public void Die()
    {
        Destroy(gameObject);
    }
}

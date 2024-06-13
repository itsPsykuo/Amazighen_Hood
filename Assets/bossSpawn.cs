using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossSpawn : MonoBehaviour
{
    public GameObject boss;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            boss.SetActive(true);
            Destroy(gameObject);
        }
    }
}

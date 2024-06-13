using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifterTurnOn : MonoBehaviour
{
    public Transform newPosition;

    public GameObject Door;
    public GameObject TurnOn;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                Instantiate(TurnOn, transform.position, transform.rotation);
                Door.transform.position = newPosition.position;
                Destroy(gameObject);
            }
        }
    }
}

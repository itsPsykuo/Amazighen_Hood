using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoBow : MonoBehaviour
{
    public Shoot shoot;
    public PlayerMovement playerMovement;

    private void Start()
    {
        shoot.enabled = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("NPC"))
        {
            if(Input.GetKey(KeyCode.E))
            {
                playerMovement.enabled = false;
                StartCoroutine(ReMove());
            }
        }
    }

    private IEnumerator ReMove()
    {
        yield return new WaitForSeconds(15f);
        playerMovement.enabled = true;
        shoot.enabled = true;
    }
}

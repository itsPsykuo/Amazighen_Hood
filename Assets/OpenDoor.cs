using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Devil;
    public Transform newPosition;
    void Update()
    {
        if (Devil == null)
        {
            gameObject.transform.position = newPosition.position;
        }
    }
}

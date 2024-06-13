using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieRespawn : MonoBehaviour
{
    public Transform CheckPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            transform.position = CheckPoint.position;
        }

        if (other.CompareTag("Devil"))
        {
            RestartScene();
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAllTheGame : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(StartAgain());
    }

    private IEnumerator StartAgain()
    {
        yield return new WaitForSeconds(25f);
        SceneManager.LoadScene(0);
    }
}

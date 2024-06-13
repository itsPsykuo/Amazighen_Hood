using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutScene : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CutScene"))
        {
            timeline.Play();
        }
    }
}

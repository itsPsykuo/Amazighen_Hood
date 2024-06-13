using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource music;

    public AudioClip musicClip;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        music.clip = musicClip;
        music.Play();
    }
}

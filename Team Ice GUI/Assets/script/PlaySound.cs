using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundPlayer;
    private void Start()
    {

    }

    private void Update()
    {

    }

    public void PlayThisSoundEffect()
    {
        soundPlayer.Play();
    }
}




  
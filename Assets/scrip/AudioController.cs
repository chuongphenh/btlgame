using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource[] audio;

    public void ToggleSound()
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
            audio[0].Play();
        }
        else
        {
            AudioListener.pause = true;
            audio[0].Pause();
        }
    }
}

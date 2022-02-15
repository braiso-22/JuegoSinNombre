using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public AudioClip sound;
    [Range(0f, 1f)]
    public float volume;
}

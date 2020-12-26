using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class LampAudioManager : MonoBehaviour
{
    [SerializeField] StudioEventEmitter emitter;
    void Update()
    {
        if (!FirstPersonController.IsOutDoor && !emitter.IsPlaying())
        {
            emitter.Play();
        }
        else if (emitter.IsPlaying() && FirstPersonController.IsOutDoor)
        {
            emitter.Stop();
        }

    }
}

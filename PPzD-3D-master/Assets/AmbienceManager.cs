using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AmbienceManager : MonoBehaviour
{
    [SerializeField] StudioEventEmitter outdoorEmitter;
    void Update()
    {
        if (FirstPersonController.IsOutDoor && !outdoorEmitter.IsPlaying())
        {
            outdoorEmitter.Play();
        }
        else if (outdoorEmitter.IsPlaying() && !FirstPersonController.IsOutDoor)
        {
            outdoorEmitter.Stop();
        }

    }
}

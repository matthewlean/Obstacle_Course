using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    ParticleSystem myParticleSystem;

    void Awake()
    {
        myParticleSystem = GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider other)
    {
        myParticleSystem.Play();
        GetComponent<MeshRenderer>.enabled = false;
    }
}

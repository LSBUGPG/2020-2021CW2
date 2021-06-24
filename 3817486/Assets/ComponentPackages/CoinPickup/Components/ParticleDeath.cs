using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDeath : MonoBehaviour
{

    public ParticleSystem particles;

    private void Start()
    {
        particles.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        particles.gameObject.SetActive(true);
    }
}

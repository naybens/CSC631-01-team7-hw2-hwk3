using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionParticle : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;
    public GameObject Cylinder;

    void OnCollisionEnter(Collision collision) {
         if (collision.gameObject.tag == "Player")
        {
            Instantiate(collisionParticleSystem);
            collisionParticleSystem.Play();
        }
    }
}

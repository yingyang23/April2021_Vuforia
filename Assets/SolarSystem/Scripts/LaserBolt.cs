using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBolt : MonoBehaviour
{

    AudioSource audioSource;
    private MeshRenderer asteroidAppearance;
    // public ParticleSystem particleSystemPrefab;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    // Unity event
    private void OnCollisionEnter(Collision collision)
    {
        // Lesson 5 Easy Mode Challenge
        if (collision.gameObject.CompareTag("Planet"))
        {
            audioSource.Play();
        }
        if (collision.gameObject.CompareTag("Moon"))
        {
            audioSource.Play();
        }

        // Lesson 5 Hard Mode Challenge
        if (collision.gameObject.CompareTag("Asteroid"))
            {
            AsteroidExplosion();
            }
 
        void AsteroidExplosion()
        {
        asteroidAppearance = collision.gameObject.GetComponent<MeshRenderer>();
        asteroidAppearance.enabled = !asteroidAppearance.enabled;
        ParticleSystem exp = collision.gameObject.GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(collision.gameObject, exp.main.duration);
        }

        // Work in progress - Alternative Lesson 5 Hard Mode Challenge
        /*spawnAsteroids();
        void spawnAsteroids()
        {
            ParticleSystem newAsteroidChunks = Instantiate(particleSystemPrefab, transform.position, Quaternion.identity);
        }*/
    }

    private void OnCollisionStay(Collision collision)
    {
    }

    private void OnCollisionExit(Collision collision)
    {
    }

}

    
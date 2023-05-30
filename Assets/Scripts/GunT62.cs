using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunT62 : MonoBehaviour
{
    public GameObject tank;
    public GameObject particlePrefab;
    public AudioSource shootingAudioSource;
    public AudioClip shootingSound;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 3f;
    public float delayBetweenShots = 5f;
    public float shootingDuration = 50f;
    private bool particlesDisplayed = false;
    private float currentShootingTime = 0f;


    private void Start()
    {
        // Add the AudioSource component to the tank GameObject
        shootingAudioSource = gameObject.AddComponent<AudioSource>();
        shootingAudioSource.clip = shootingSound;

        // Instantiate the particle prefab at the start and hide it
        GameObject particles = Instantiate(particlePrefab, tank.transform.position, Quaternion.identity);
        particles.SetActive(false);

        // Delay the initial shooting visibility by 30 seconds, then call the function StartShooting
        Invoke("StartShooting", 0f);

        // Display the particle prefab after 50 seconds from shooting
        Invoke("DisplayParticles", 50f);

    }


    private void StartShooting()
    {
        // Start shooting repeatedly with a delay
         InvokeRepeating("ShootBullet", 0f, delayBetweenShots);
    }

    private void ShootBullet()
    {
        // Check if shooting time is within the desired duration
        if (currentShootingTime < shootingDuration)
        {
            // Increment the shooting time
            currentShootingTime += delayBetweenShots;

            // Perform shooting logic
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            shootingAudioSource.Play();
        }
        else
        {
            // Stop shooting
            CancelInvoke("ShootBullet");
        }
    }

     private void DisplayParticles()
    {
        if (!particlesDisplayed)
        {
            Vector3 particlePosition = tank.transform.position;
            particlePosition.y += 0.5f;

            GameObject particles = Instantiate(particlePrefab, particlePosition, Quaternion.identity);
            particles.transform.eulerAngles = new Vector3(-90f, 0f, 0f);
            particlesDisplayed = true;
            // Set the tank inactive after 20 seconds
            Invoke("DestroyTank", 20f);
        }
    }

    private void DestroyTank()
    {
        tank.SetActive(false);
    }

}

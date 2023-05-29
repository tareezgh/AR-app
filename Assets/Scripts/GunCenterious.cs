using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCenterious : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public AudioSource shootingAudioSource;
    public AudioClip shootingSound;
    public float bulletSpeed = 10f;
    public float shootingDuration = 60f;
    public float delayBetweenShots = 3f; 

    private float currentShootingTime = 0f;

    private void Start()
    {
        // Add the AudioSource component to the tank GameObject
        shootingAudioSource = gameObject.AddComponent<AudioSource>();
        shootingAudioSource.clip = shootingSound;

        // Delay the initial shooting by 30 seconds
        Invoke("StartShooting", 30f);
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
            // Stop shooting when the desired duration is reached
            CancelInvoke("ShootBullet");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunT62 : MonoBehaviour
{
    public GameObject tank;
    public GameObject particlePrefab;
    private bool particlesDisplayed = false;
    
    private void Start()
    {
        // Instantiate the particle prefab at the start and hide it
        GameObject particles = Instantiate(particlePrefab, tank.transform.position, Quaternion.identity);
        particles.SetActive(false);

        // Display the particle prefab after 50 seconds 
        Invoke("DisplayParticles", 50f);

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

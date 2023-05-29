// using UnityEngine;

// public class PlayerController : MonoBehaviour
// {
//     public AudioClip startSound;
//     public float movementSpeed = 1f;
//     public float rotationSpeed = 50.0f;
//     public float loopDistance = 5.0f;


//     private Vector3 initialPosition;
//     private AudioSource audioSource;
//     private bool isMoving = false;

//     private void Start()
//     {
//         initialPosition = transform.position;
//         audioSource = GetComponent<AudioSource>();
//         audioSource.clip = startSound;
//         audioSource.Play();
//         isMoving = false;
//     }

//     private void Update()
//     {
//         if (!audioSource.isPlaying && !isMoving)
//         {
//             isMoving = true;
//             // Set initial forward movement
//             transform.Translate(0, 0, 1f * Time.deltaTime * movementSpeed);
//         }

//         if (isMoving)
//         {
//             // Code for player movement
//             float horizontalMovement = Input.GetAxis("Horizontal");

//             transform.Rotate(0, horizontalMovement * Time.deltaTime * rotationSpeed, 0);

//             float moveDistance = Mathf.PingPong(Time.time * movementSpeed, loopDistance);
//             transform.Translate(0, 0, moveDistance * Time.deltaTime);

           
//         }
//     }

// }

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip startSound;
    public float movementSpeed = 1f;
    public float rotationSpeed = 50.0f;
    public float stopPosition = 1f;
    public float targetPosition; // Specify the target X position

    private AudioSource audioSource;
    private bool isMoving = false;

    // private void Start()
    // {
    //     audioSource = GetComponent<AudioSource>();
    //     audioSource.clip = startSound;
    //     audioSource.Play();
    //     isMoving = false;
    // }

    // private void Update()
    // {
    //     if (!audioSource.isPlaying && !isMoving)
    //     {
    //         isMoving = true;
    //         // Set initial forward movement
    //         transform.Translate(0, 0, 1f * Time.deltaTime * movementSpeed);
    //     }

    //     if (isMoving)
    //     {
    //         // Code for player movement
    //         float horizontalMovement = Input.GetAxis("Horizontal");

    //         transform.Rotate(0, horizontalMovement * Time.deltaTime * rotationSpeed, 0);
    //         transform.Translate(0, 0, 1f * Time.deltaTime * movementSpeed);

    //         // Check if the player has reached the target position
    //         if (Mathf.Approximately(transform.position.x, targetPosition))
    //         {
    //             isMoving = false;
    //             // Stop the player's movement
    //             // Optionally, you can add additional actions here
    //         }
    //     }
    // }
}



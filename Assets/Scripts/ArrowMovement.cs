using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    [System.Serializable]
    public struct TargetPosition
    {
        public float x;
        public float y;
    }

    public TargetPosition[] targetPositions; // Array to hold the target positions for each arrow
    public float speed = 5f; // Adjust this value to control the speed of the arrows

    private int currentTargetIndex = 0; // Index of the current target position

    void Update()
    {
        // Get the current target position
        Vector3 targetPosition = new Vector3(targetPositions[currentTargetIndex].x, targetPositions[currentTargetIndex].y, 0f);

        // Ignore the Z coordinate of the target position and set it to the current Z coordinate of the arrow
        targetPosition.z = transform.position.z;

        // Calculate the direction towards the current target position
        Vector3 direction = (targetPosition - transform.position).normalized;

        // Calculate the distance between the current position and the target position
        float distanceToTarget = Vector3.Distance(transform.position, targetPosition);

        // Check if the distance is greater than the minimum threshold
        if (distanceToTarget > 0.1f)
        {
            // Calculate the new position based on the direction and the speed
            Vector3 newPosition = transform.position + direction * speed * Time.deltaTime;

            // Move the arrow to the new position
            transform.position = newPosition;
        }
        else
        {
            // Set the position directly to the target position
            transform.position = targetPosition;

            // Increment the target index or reset it to 0 if it exceeds the array length
            currentTargetIndex = (currentTargetIndex + 1) % targetPositions.Length;
        }
    }
}

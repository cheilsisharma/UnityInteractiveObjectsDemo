using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the movement speed as needed

    void Update()
    {
        // Get the input for movement in both horizontal and vertical axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Move the player
        transform.Translate(movement);
    }
}

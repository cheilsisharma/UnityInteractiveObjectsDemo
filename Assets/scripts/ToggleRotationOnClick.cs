using UnityEngine;

public class ToggleRotationOnClick : MonoBehaviour
{
    private bool isRotating = false;
    public float rotationSpeed = 45f; // Adjust the rotation speed as needed

    void Update()
    {
        // Check if the object is set to rotate
        if (isRotating)
        {
            // Rotate the object around its up (Y) axis
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    void OnMouseDown()
    {
        // Toggle the rotation state
        isRotating = !isRotating;
    }
}

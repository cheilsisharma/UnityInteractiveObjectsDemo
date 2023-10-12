using UnityEngine;

public class game : MonoBehaviour
{
    private Renderer objectRenderer;
    private bool isGreen = false;
    private Color blueColor = Color.blue;
    private Color greenColor = Color.green;

    void Start()
    {
        // Get the Renderer component of the object
        objectRenderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        // Toggle the color between blue and green
        isGreen = !isGreen;

        // Set the object's color based on the toggle state
        objectRenderer.material.color = isGreen ? greenColor : blueColor;
    }
}

using UnityEngine;

public class ToggleSizeChangeOnClick : MonoBehaviour
{
    private Vector3 initialScale;
    private bool isScaled = false;
    public float scaleSpeed = 1.0f; // Adjust the scaling speed as needed
    public float maxScaleFactor = 2.0f; // The maximum scaling factor

    void Start()
    {
        // Store the initial scale of the object
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Check if the object is set to scale
        if (isScaled)
        {
            // Gradually scale the object up
            Vector3 newScale = transform.localScale + Vector3.one * scaleSpeed * Time.deltaTime;
            transform.localScale = newScale;

            // Check if the object has reached or exceeded the maximum scale
            if (transform.localScale.x >= initialScale.x * maxScaleFactor)
            {
                // Stop scaling and set it to the maximum scale
                isScaled = false;
                transform.localScale = initialScale * maxScaleFactor;
            }
        }
    }

    void OnMouseDown()
    {
        // Toggle the scaling state
        isScaled = !isScaled;

        if (!isScaled)
        {
            // Reset the object's scale to the initial scale
            transform.localScale = initialScale;
        }
    }
}

using UnityEngine;

public class MovementUp : MonoBehaviour
{
    public float speed = 1.0f;
    public float distance = 1.0f;
    public Vector3 originalPosition;

    private bool goingUp = true;
    private Vector3 targetPosition;

    void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition + Vector3.up * distance;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        
        if (goingUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
            if (transform.position == targetPosition)
            {
                goingUp = false;
                targetPosition = originalPosition;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
            if (transform.position == targetPosition)
            {
                goingUp = true;
                targetPosition = originalPosition + Vector3.up * distance;
            }
        }
    }
}

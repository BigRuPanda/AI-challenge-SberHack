using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    public float speed = 2.0f;
    public float distance = 5.0f;

    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool movingToEnd = true;

    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + Vector3.up * distance; 
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        if (movingToEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, step);
            if (transform.position == endPosition)
                movingToEnd = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, step);
            if (transform.position == startPosition)
                movingToEnd = true;
        }
    }
}

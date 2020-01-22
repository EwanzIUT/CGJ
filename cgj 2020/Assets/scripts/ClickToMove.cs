using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
  

    // Update is called once per frame

    private float speed = 6;
    private Vector3 targetPosition;

    private bool isMoving = false;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            setTargetPosition();
        }

        if (isMoving)
        {
            Move();
        }
    }

    void setTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
 
        isMoving = true;

    }

    void Move()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (transform.position == targetPosition)
        {
            isMoving = false;
        }
    }
}

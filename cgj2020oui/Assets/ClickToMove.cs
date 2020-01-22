using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
  

    // Update is called once per frame

    private float speed = 6;
    private Vector3 targetPosition;
   

    private bool isMoving = false;
    public Animator animator;

    private bool yplus = false;
    private bool ymoins = false;
    private bool xplus = false;
    private bool xmoins = false;


    void Update()
    {
        

        animator.SetBool("bougeF", isMoving);
        animator.SetBool("Yplus", yplus);
        animator.SetBool("Ymoins", ymoins);
        animator.SetBool("Xplus", xplus);
        animator.SetBool("Xmoins", xmoins);


        if (Input.GetMouseButton(0))
        {
            setTargetPosition();
        }

        if (isMoving)
        {
            Move();
            avancedos();
            avanceface();
            avancedoite();
            avancegauche();
        }

        /*print(transform.position.x);
        print(transform.position.y);*/

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

    
    void avancedos()
    {
        if (transform.position.y < targetPosition.y)
        {
            yplus = true;
        }

        if (transform.position.y == targetPosition.y)
        {
            yplus = false;
        }

    }

    void avanceface()
    {
        if (transform.position.y > targetPosition.y)
        {
            ymoins = true;
        }

        if (transform.position.y == targetPosition.y)
        {
            ymoins = false;
        }

    }

    void avancedoite()
    {
        if (transform.position.x < targetPosition.x)
        {
            xplus = true;
        }

        if (transform.position.x == targetPosition.x)
        {
            xplus = false;
        }
    }

    void avancegauche()
    {
        if (transform.position.x > targetPosition.x)
        {
            xmoins = true;
        }

        if (transform.position.x == targetPosition.x)
        {
            xmoins = false;
        }

    }



}

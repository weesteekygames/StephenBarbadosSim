using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrProjectileMovement : MonoBehaviour
{
    private Vector2 targetPos;
    private float bulletSpeed = 1.0f; 
    // Start is called before the first frame update
    void Start()
    {
        targetPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = new Vector2(0, 0);
        
        // LEFT
        if (transform.position.x > (targetPos.x + bulletSpeed))
        {
            newPos = transform.position;
            newPos.x -= bulletSpeed;
            transform.position = newPos;
        }
        else if (transform.position.x < (targetPos.x + bulletSpeed) && (transform.position.x > targetPos.x))
        {
            newPos = transform.position;
            newPos.x = targetPos.x;
            transform.position = newPos;
        }

        // RIGHT
        if (transform.position.x < (targetPos.x - bulletSpeed))
        {
            newPos = transform.position;
            newPos.x += bulletSpeed;
            transform.position = newPos;
        }
        else if (transform.position.x > (targetPos.x + bulletSpeed) && (transform.position.x < targetPos.x))
        {
            newPos = transform.position;
            newPos.x = targetPos.x;
            transform.position = newPos;
        }

        // DOWN
        if (transform.position.y < (targetPos.y + bulletSpeed))
        {
            newPos = transform.position;
            newPos.y += bulletSpeed;
            transform.position = newPos;
        }
        else if (transform.position.y > (targetPos.y + bulletSpeed) && (transform.position.y < targetPos.y))
        {
            newPos = transform.position;
            newPos.y = targetPos.y;
            transform.position = newPos;
        }

        // DOWN
        if (transform.position.y > (targetPos.y + bulletSpeed))
        {
            newPos = transform.position;
            newPos.y -= bulletSpeed;
            transform.position = newPos;
        }
        else if (transform.position.y < (targetPos.y + bulletSpeed) && (transform.position.y > targetPos.y))
        {
            newPos = transform.position;
            newPos.y = targetPos.y;
            transform.position = newPos;
        }

        //needs improvement
        if (targetPos.x == transform.position.x && targetPos.y == transform.position.y)
        {
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using levelConstants;

public class scrPlayerMovement : MonoBehaviour
{
    private float pSpeed = 0.7f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * pSpeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * pSpeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("w") && 
            transform.position.y <= levelConstants.scrLevelConstants.V_VERTICAL_MOVEMENT_TOP)
        {
            transform.position += Vector3.up * pSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") && 
            transform.position.y >   levelConstants.scrLevelConstants.V_VERTICAL_MOVEMENT_BOTTOM)
        {
            transform.position += Vector3.down * pSpeed * Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left button pressed");
        }
    }
}

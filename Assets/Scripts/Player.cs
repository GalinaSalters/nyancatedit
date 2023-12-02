using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 moveVector;
    public float speed;
    public float vLimit = 4.7f;

    // privates
    private float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveSpeed = speed * Time.deltaTime;

        transform.Translate(moveVector * moveSpeed);

        DownHandler();
        UpHandler(); 
    }

    private void DownHandler()
    {
        /*
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(moveSpeed * Vector3.down);
        }
        */
        if (transform.position.y < -vLimit)
        {
            transform.position = new Vector3(transform.position.x, -vLimit, transform.position.z);
        }        
    }

    private void UpHandler()
    { 
        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(moveSpeed * Vector3.up);
        }
        */

        if (transform.position.y > vLimit)
        {
            transform.position = new Vector3(transform.position.x, vLimit, transform.position.z);
        }
    }
}

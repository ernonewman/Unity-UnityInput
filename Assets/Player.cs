using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 3.5f;
    public float JumpingForce = 10f;
    public float RotatingSpeed = 140f;

    private bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(transform.position, Vector3.up, -RotatingSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(transform.position, Vector3.up, RotatingSpeed * Time.deltaTime);
        }

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position += transform.ba * Speed * Time.deltaTime;
        //}

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            GetComponent<Rigidbody>().AddForce(0, JumpingForce, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Floor")
        {
            canJump = true;
            Debug.Log("hit the floor!");
        }
    }
}

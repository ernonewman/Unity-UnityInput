using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Move left");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Move right");
        }
    }
}

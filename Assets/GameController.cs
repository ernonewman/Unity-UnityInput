using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] GameCameras;

    private int gameCameraIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        FocusOnCamera(gameCameraIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeCamera(1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            ChangeCamera(-1);
        }
    }

    void FocusOnCamera(int index)
    {
        for (int i = 0; i < GameCameras.Length; i++)
        {
            GameCameras[i].SetActive(i == index);
        }
    }

    void ChangeCamera(int direction)
    {
        gameCameraIndex += direction;

        if (gameCameraIndex >= GameCameras.Length)
        {
            gameCameraIndex = 0;
        }
        else if (gameCameraIndex < 0)
        {
            gameCameraIndex = GameCameras.Length - 1;
        }

        FocusOnCamera(gameCameraIndex);
    }
}

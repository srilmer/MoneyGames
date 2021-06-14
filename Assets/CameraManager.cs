using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject diceCamera;
    public GameObject playboardCamera;

    public GameObject[] playerCamera;

    public void SetDiceCamera()
    {
        diceCamera.SetActive(true);
        playboardCamera.SetActive(false);
        foreach (GameObject camera in playerCamera)
        {
            camera.SetActive(false);
        }
    }

    public void SetPlayboardCamera()
    {
        diceCamera.SetActive(false);
        playboardCamera.SetActive(true);
        foreach (GameObject camera in playerCamera)
        {
            camera.SetActive(false);
        }
    }

    public void SetPlayerCamera(int player)
    {
        diceCamera.SetActive(false);
        playboardCamera.SetActive(false);
        foreach (GameObject camera in playerCamera)
        {
            camera.SetActive(false);
        }
        playerCamera[player].SetActive(true);
    }
}

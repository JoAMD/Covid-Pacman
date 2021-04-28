using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    private PlayerController lastActivePlayer;

    //Getter and setter
    //private PlayerController LastActivePlayer { get => lastActivePlayer; set => lastActivePlayer = value; }

    public void UpdateActivatePlayer(PlayerController playerController)
    {
        if (lastActivePlayer != null)
        {
            Debug.Log("made inactive");
            lastActivePlayer.SetIsActive(false);
        }
        else
        {
            Debug.Log("Last active player = " + lastActivePlayer + " is null");
        }
        lastActivePlayer = playerController;
        Debug.Log("Last active player = " + lastActivePlayer);
    }
}

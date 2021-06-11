using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Text _roomName;

    public void OnClick_CreateRoom() {
        
        if(!PhotonNetwork.IsConnected) {
            return;
        }

        // Room options
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 6;

        if(_roomName.text.Length <1)
        {
            _roomName.text = "New Room";
        }
        PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("Created room '" + _roomName.text + "' successfully.", this);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Creation of room '" + _roomName.text + "' failed: " + message, this);
    }
}

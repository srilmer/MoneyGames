using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class RoomListingsMenu : MonoBehaviourPunCallbacks
{
    // Content in de list of rooms
    [SerializeField]
    private Transform _content;

    [SerializeField]
    private RoomListing _roomlisting;

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach(RoomInfo info in roomList) {
            RoomListing listing = Instantiate(_roomlisting, _content);
    
            if(listing != null) {
                listing.SetRoomInfo(info);
            }
        }
    }
}

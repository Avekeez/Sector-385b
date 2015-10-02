using UnityEngine;
using System.Collections;

public class NetworkManager : Photon.PunBehaviour {
    void Start () {
        PhotonNetwork.ConnectUsingSettings ("0");
        PhotonNetwork.logLevel = PhotonLogLevel.Full;
    }

    void OnGUI () {
        GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString ());
    }

    public override void OnJoinedLobby () {
        PhotonNetwork.JoinRandomRoom ();
    }

    void OnPhotonRandomJoinFailed () {
        print ("o fuk");
        PhotonNetwork.CreateRoom (null);
    }

    public override void OnJoinedRoom () {
        GameObject cube = PhotonNetwork.Instantiate ("Cube", Vector3.zero, Quaternion.identity, 0);
    }
}

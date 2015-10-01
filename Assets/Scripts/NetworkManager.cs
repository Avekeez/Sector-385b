using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

    private const string typeName = "name";
    private const string gameName = "room";

    private void StartServer () {
        Network.InitializeServer (4, 25000, !Network.HavePublicAddress ());
        MasterServer.RegisterHost (typeName, gameName);
    }

    void OnServerInitialized () {
        print ("Server Initialized...");
    }

    void OnGUI () {
        if (!Network.isClient && ! Network.isServer) {
            if (GUI.Button (new Rect (100, 100, 250, 100), "Start Server")) {
                StartServer ();
            }
        }
    }
	
	void Update () {
	
	}
}

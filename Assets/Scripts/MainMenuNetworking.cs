using System.Collections;
using System.Collections.Generic;
using TMPro;
using Photon.Pun;
using UnityEngine;
using Photon.Realtime;

public class MainMenuNetworking : MonoBehaviourPunCallbacks
{

  /*  [SerializeField] private GameObject findOpponentPanel = null;*/
    [SerializeField] private GameObject waitingStatusPanel = null;
    [SerializeField] private TextMeshProUGUI waitingStatusText = null;

    private bool isConnecting = false;

    private const string GameVersion = "0.1";
    private const int MaxPlayersInRoom = 2;

    private void Awake() => PhotonNetwork.AutomaticallySyncScene = true;

    public void FindOpponent()
    {
        isConnecting = true;

        /*findOpponentPanel.SetActive(false);*/
        waitingStatusPanel.SetActive(true);

        waitingStatusText.text = "Trying to find somebody worthy...";

        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            PhotonNetwork.GameVersion = GameVersion;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");

        if (isConnecting)
        {
            PhotonNetwork.JoinRandomRoom();
        }
    }
        public override void OnDisconnected(DisconnectCause cause)
    {
        waitingStatusPanel.SetActive(false);
        /*findOpponentPanel.SetActive(true);*/

        Debug.Log($"Disconnected due to: {cause}");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("No other people want to play with you. Creating a new room so you can play on your own. Sad.");

        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = MaxPlayersInRoom });
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Client has joined the room!");

        int playerCount = PhotonNetwork.CurrentRoom.PlayerCount;

        if(playerCount != MaxPlayersInRoom)
        {
            waitingStatusText.text = "Waiting for your challenger.";
            Debug.Log("Client is waiting for an opponent");
        }
        else
        {
            waitingStatusText.text = "Let the match commence!";
            Debug.Log("Matching is ready to begin");
        }

    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        if(PhotonNetwork.CurrentRoom.PlayerCount == MaxPlayersInRoom)
        {
            PhotonNetwork.CurrentRoom.IsOpen = false;

            waitingStatusText.text = "Opponent found!";
            Debug.Log("Match is ready to begin");

            PhotonNetwork.LoadLevel("Football");

        }
    }

}




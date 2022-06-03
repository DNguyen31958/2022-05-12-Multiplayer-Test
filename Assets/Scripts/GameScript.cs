using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviourPunCallbacks
{
    public TMP_Text roomName;
    public TMP_Text pingText;

    void Start()
    {
        roomName.text = "Room Name: " + LobbyScript.roomName;
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("2 Lobby");
    }

    private void Update()
    {
        pingText.text = "Ping: " + PhotonNetwork.GetPing();
    }
}

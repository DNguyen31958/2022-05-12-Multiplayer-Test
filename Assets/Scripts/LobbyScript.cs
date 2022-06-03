using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class LobbyScript : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;
    public static string roomName;
    public TMP_Text errorMessage;

    public void CreateRoom()
    {
        if(createInput.text != "")
        {
            roomName = createInput.text;
            PhotonNetwork.CreateRoom(createInput.text);
        }
        else
        {
            BlankField();
        }
    }

    public void JoinRoom()
    {
        if(joinInput.text != "")
        {
            roomName = joinInput.text;
            PhotonNetwork.JoinRoom(joinInput.text);
        }
        else
        {
            BlankField();
        }
    }

    public void BlankField()
    {
        errorMessage.text = "Blank input field";
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("3 Game");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        errorMessage.text = message;
    }
}

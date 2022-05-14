using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerScript : MonoBehaviourPunCallbacks
{
    PhotonView pView;

    void Start()
    {
        pView = GetComponent<PhotonView>();
    }

    void Update()
    {
        if(pView.IsMine)
        {
            float xInput = Input.GetAxis("Horizontal") * 10f * Time.deltaTime;
            transform.position = new Vector3(transform.position.x + xInput, transform.position.y, transform.position.z);
        }
    }
}

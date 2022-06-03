using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerScript : MonoBehaviourPunCallbacks
{
    private float moveSpeed = 10f;
    private float jumpForce = 4f;

    private Rigidbody2D rb;
    private PhotonView pView;

    void Start()
    {
        pView = GetComponent<PhotonView>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(pView.IsMine)
        {
            float xInput = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x + xInput, transform.position.y);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + jumpForce);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class MultiPlayerInput : PlayerInput
{
    PhotonView view;

    protected void Start()
    {
        view = GetComponent<PhotonView>();
    }

    protected override void Update()
    {
        if (view.IsMine)
            base.Update();
    }
}

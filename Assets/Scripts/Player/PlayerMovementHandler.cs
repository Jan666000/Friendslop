using System.Collections.Generic;
using UnityEngine;
using Mirror;

namespace Friendslop 
{
    public class PlayerMovementHandler : NetworkBehaviour
    {
        private Vector3 playerMovement;
        void Update() 
        {
            if (isLocalPlayer) 
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");
                playerMovement = new Vector3(h * 0.25f, v * 0.25f, 0f);
                
            }
        }

        void FixedUpdate() 
        {
            transform.position = transform.position + playerMovement;
        }
    }
}


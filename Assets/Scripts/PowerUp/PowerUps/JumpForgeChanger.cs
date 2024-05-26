using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpForgeChanger : MonoBehaviour
{
    [SerializeField] float JumpSpeed = 15f;
    [SerializeField] float recoveryTime = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IPowerUpTriger powerUpTriger = collision.GetComponent<IPowerUpTriger>();

        if(powerUpTriger != null)
        {
            PUP_JumpSpeed pUP_JumpSpeed = new PUP_JumpSpeed();

            pUP_JumpSpeed.jumpSpeed = JumpSpeed;
            pUP_JumpSpeed.time = recoveryTime;
            powerUpTriger.PowerUpdate(pUP_JumpSpeed);
            Destroy(this.gameObject);
        }
    }
}

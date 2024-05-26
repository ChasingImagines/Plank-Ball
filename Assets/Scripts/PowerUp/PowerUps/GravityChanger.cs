using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    [SerializeField] float gravity = 1;
    [SerializeField] float recoveryTime = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IPowerUpTriger powerUpTriger = collision.gameObject.GetComponent<IPowerUpTriger>();

        if (powerUpTriger != null)
        {
            PUP_Gravity pupGravity = new PUP_Gravity();
            pupGravity.gravity = gravity;
            pupGravity.time = recoveryTime;
            powerUpTriger.PowerUpdate(pupGravity);
            Destroy(this.gameObject);
        }
    }
}

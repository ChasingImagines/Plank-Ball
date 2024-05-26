using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUPer : MonoBehaviour
{

    [SerializeField] int health = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IPowerUpTriger powerUpTriger = collision.GetComponent<IPowerUpTriger>();
        if(powerUpTriger != null)
        {

            PUP_Health upHealth = new PUP_Health();
            upHealth.health = health;


            powerUpTriger.PowerUpdate(upHealth);
            Destroy(this.gameObject);
        }
    }


}

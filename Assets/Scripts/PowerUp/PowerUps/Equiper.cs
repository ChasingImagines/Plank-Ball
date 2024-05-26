using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equiper : MonoBehaviour
{
    [SerializeField] GameObject obj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IPowerUpTriger powerUpTriger = collision.GetComponent<IPowerUpTriger>();
        if(powerUpTriger != null)
        {
            powerUpTriger.PowerUpdate(obj);
            Destroy(this.gameObject);
        }
    }
}

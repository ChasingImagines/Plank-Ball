using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] int damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ISpikeTriger spikeTriger = collision.GetComponent<ISpikeTriger>();
        if(spikeTriger != null)
        {
            collision.GetComponent<ILÝfeForm>()?.TakeDamege(damage);
        }
    }
}

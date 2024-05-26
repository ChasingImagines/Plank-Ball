using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    int dameage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IKnifeTriger  knifeTriger = collision.gameObject.GetComponent<IKnifeTriger>();
        if(knifeTriger != null)
        {
            knifeTriger.TakeDamege(dameage);
            Destroy(this.gameObject);
        }
    }
}

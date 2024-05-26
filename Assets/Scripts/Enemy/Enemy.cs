using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy :MonoBehaviour ,IKnifeTriger
{
    [SerializeField] int health = 1;
    [SerializeField] int damage = 1;
    [SerializeField] GameObject insectSund;
    [SerializeField] GameObject inscetParicle;


    public void TakeDamege(int takedamage)
    {
        health -= takedamage;
        if (health <= 0)
        {
            Instantiate(insectSund, this.transform.position, this.transform.rotation);
            Instantiate(inscetParicle, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        IL›feForm l›feForm = collision.gameObject.GetComponent<IL›feForm>();

        if ( !(l›feForm is IEnemeyTriger ) ) return;

        if (l›feForm != null)
        {
            l›feForm.TakeDamege(damage);
           
        }
    }

    
}

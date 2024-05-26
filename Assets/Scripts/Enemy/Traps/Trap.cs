using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] int damage = 1;
    [SerializeField] float onOffTime = 5f;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite onSprite;
    [SerializeField] Sprite offSprite;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ITrapTriger trapTriger = collision.GetComponent<ITrapTriger>();
        if(trapTriger != null)
        {
             collision.GetComponent<ILÝfeForm>()?.TakeDamege(damage);
        }
    }

    private void Awake()
    {
        StartCoroutine(ONOff());
    }

    IEnumerator ONOff()
    {
        while(true)
        {
            yield return new WaitForSeconds(onOffTime);
            this.GetComponent<Collider2D>().enabled = false;
            spriteRenderer.sprite = offSprite;
            yield return new WaitForSeconds(onOffTime);
            this.GetComponent<Collider2D>().enabled = true;
            spriteRenderer.sprite = onSprite;
        }
        
    }

}

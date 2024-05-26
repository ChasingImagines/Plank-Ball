using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, ILÝfeForm ,IEnemeyTriger,IBlackHoleTriger,IFinishLineTriger,ITrapTriger,ISpikeTriger
{
    [SerializeField] public int health = 5;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpForge = 5f;
    [SerializeField] GameObject diePariclePrefab;
    [SerializeField] AudioSource jumpAudio;
    [SerializeField] Transform platform;
    [SerializeField] float dieLenghtDown = 20;
    [SerializeField] float dieLenghtUp = 35;
    [SerializeField] GameObject menuInGame;
    [SerializeField] AudioSource damageAudo;

    public float JumpForgeGet()
    {
        return jumpForge;
    } 
    public void JumpForgeSet(float forge)
    {
        jumpForge = forge;
    }


    private void Update()
    {
        if(platform != null)
        {
            Debug.Log("çlisti");
            if(Mathf.Abs(platform.position.y  - this.transform.position.y) > 
                dieLenghtDown && platform.position.y  > this.transform.position.y  )
            {
                health =1;
                TakeDamege(2);
            }
           /* else if (Mathf.Abs(platform.position.y - this.transform.position.y) >
                dieLenghtUp && platform.position.y < this.transform.position.y)
            {
                health = 1;
                TakeDamege(2);
            }*/
        }
    }

    private void Start()
    {
        GameManager.Instance.health = health;

    }
    public void TakeDamege(int damage)
    {
        if(damage > 0 && health >1)
        {
            damageAudo.Play();
        }
       
        health -= damage;
        GameManager.Instance.health = health;
        Debug.Log("Player health: " + health);
        if (health <= 0)
        {
            Instantiate(diePariclePrefab,this.transform.position,this.transform.rotation);
            menuInGame.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IBallTriger ballTriger= collision.gameObject.GetComponent<IBallTriger>();
        if (ballTriger != null)
        {
            Debug.Log("zýpla");
            jumpAudio?.Play();
            rb.AddForce(Vector2.up * jumpForge,ForceMode2D.Impulse);
        }
    }

}

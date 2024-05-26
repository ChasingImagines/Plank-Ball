using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ball))]
[RequireComponent(typeof(Rigidbody2D))]
public class PowerUpUser : MonoBehaviour, IPowerUpTriger
{
     
    float oldGravity = 0f;
    float oldJumpSpeed = 0f;
    [SerializeField] Flower flower;
    [SerializeField] AudioSource powerupAudio;

    private Rigidbody2D rb;
    private Ball  ball;


    private Coroutine corGrvity;
    private Coroutine corJumpSpeed;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        
        ball = this.GetComponent<Ball>();

        oldGravity   = rb.gravityScale;
        oldJumpSpeed = ball.JumpForgeGet();
    }



    public void PowerUpdate(GameObject gmObj)
    {
        if(flower == null)
        {
            Debug.LogWarning("Null Flower");
            return;
        }
        foreach(Transform child in flower.transform.GetComponent<Transform>())
        {
            if (child == null) continue;
            Destroy(child.gameObject);
        }

        gmObj = Instantiate(gmObj,flower.transform);
        gmObj.transform.parent = flower.transform;

       
    }

    public void PowerUpdate(PUP_Health health)
    {
        this.gameObject.GetComponent<ILÝfeForm>()?.TakeDamege(-health.health);
        powerupAudio.Play();
    }

    public void PowerUpdate(PUP_Gravity gravity)
    {
        if(corGrvity != null)
        {
            StopCoroutine(corGrvity);
            corGrvity = null;
        }
        corGrvity = StartCoroutine(ChangeGrvity(gravity));
        powerupAudio.Play();
    }

    public void PowerUpdate(PUP_JumpSpeed jumpSpeed)
    {
        if(corJumpSpeed != null)
        {
            StopCoroutine(corJumpSpeed);
            corJumpSpeed = null;
        }
        corJumpSpeed = StartCoroutine(ChangeJumpSpeed(jumpSpeed));
        powerupAudio.Play();

    }


    IEnumerator ChangeGrvity( PUP_Gravity gravity)
    {
        rb.gravityScale = gravity.gravity;
        yield return new WaitForSecondsRealtime(gravity.time);
        if(rb!= null) rb.gravityScale = oldGravity;
    }

    IEnumerator ChangeJumpSpeed( PUP_JumpSpeed jumpSpeed)
    {
        ball.JumpForgeSet(jumpSpeed.jumpSpeed);
        yield return new WaitForSecondsRealtime(jumpSpeed.time);
        if(ball!= null)ball.JumpForgeSet(oldJumpSpeed);
    }



   
}

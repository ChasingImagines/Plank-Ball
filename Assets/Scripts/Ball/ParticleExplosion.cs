using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleExplosion : MonoBehaviour
{
    [SerializeField] List<GameObject> particles = new List<GameObject>();

    [SerializeField] float forge = 24;

    private void Start()
    {
        Explosion();
    }

    public void Explosion()
    {
        foreach (var p in particles)
        {
            Vector2 drection = new Vector2(Random.Range(-100f, 100f), Random.Range(-100f, 100f)).normalized;
            
             float  randomForge = Random.Range(-forge, forge);

            p.GetComponent<Rigidbody2D>().AddForce(drection*forge, ForceMode2D.Impulse);
        }
    }
}

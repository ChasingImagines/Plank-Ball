using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOfDestroy : MonoBehaviour
{
    public float lifeTime = 2;

    private void Start()
    {
        Destroy(gameObject,lifeTime);
    }
}

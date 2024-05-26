using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField] Transform targetTransform;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (targetTransform == null)
        {
            Debug.LogWarning("null target transform");
            return;
        }
        IBlackHoleTriger blackHoleTriger = collision.gameObject.GetComponent<IBlackHoleTriger>();
        if (blackHoleTriger != null)
        {
            collision.transform.position = targetTransform.position;
            Debug.Log("teleport");
        }
    }
}

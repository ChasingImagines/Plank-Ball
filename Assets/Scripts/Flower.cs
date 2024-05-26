using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    [SerializeField] Transform targetTransform;

    private void Update()
    {
        if (targetTransform == null) return;
        this.transform.position = targetTransform.position;
        this.transform.rotation = targetTransform.rotation;
    }
}

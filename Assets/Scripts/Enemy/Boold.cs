using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boold : MonoBehaviour
{
    [SerializeField] List<Sprite> sprites = new List<Sprite>();

    [SerializeField] SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer.sprite = sprites[Random.Range(0,sprites.Count)];
       
    }

}

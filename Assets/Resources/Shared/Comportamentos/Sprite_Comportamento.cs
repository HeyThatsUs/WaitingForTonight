using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Comportamento : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private bool MostrarSprite;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.enabled = MostrarSprite;

    }
}

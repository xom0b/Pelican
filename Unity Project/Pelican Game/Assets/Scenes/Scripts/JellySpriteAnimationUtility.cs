using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Swaps out the sprite of a Unity Jelly Sprite at runtime for animations
/// </summary>
public class JellySpriteAnimationUtility : MonoBehaviour
{
    public UnityJellySprite jellySprite;
    public SpriteRenderer spriteRenderer;

    private void LateUpdate()
    {
        if (jellySprite.m_Sprite != spriteRenderer.sprite)
        {
            jellySprite.m_Sprite = spriteRenderer.sprite;
            jellySprite.OnChangeSprite();
        }
    }
}

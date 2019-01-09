using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitBoxColliderToSprite : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public SpriteRenderer sprite;
    
    public void ResizeBoxColliderToSprite()
    {
        if (boxCollider != null && sprite != null)
        {
            Vector2 spriteSize = sprite.bounds.size;
            boxCollider.size = new Vector2(spriteSize.x / sprite.transform.lossyScale.x, spriteSize.y / sprite.transform.lossyScale.y);
            boxCollider.offset = new Vector2(0f, 0f);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Helpers;
using UnityEngine;

public class HitBoxController : MonoBehaviour
{
    [SerializeField] private Sprite playerOneSprite;   
    [SerializeField] private Sprite playerTwoSprite;   
    
    private void OnMouseDown()
    {
        var spriteRenderer = this.GetComponent<SpriteRenderer>();

        if (spriteRenderer.sprite != null) return;
        
        spriteRenderer.sprite = GameManager.SharedInstance.GetCurrentTurn() == PlayerTurn.PlayerOne 
            ? playerOneSprite 
            : playerTwoSprite;
        
        GameManager.SharedInstance.NextTurn();
    }
}

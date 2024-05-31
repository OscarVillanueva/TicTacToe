using System;
using System.Collections;
using System.Collections.Generic;
using Helpers;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager SharedInstance;

   private PlayerTurn _currentTurn = PlayerTurn.PlayerOne;
   
   private void Awake()
   {
      if (!SharedInstance) SharedInstance = this;
      else Destroy(SharedInstance);
   }

   public PlayerTurn GetCurrentTurn()
   {
      return _currentTurn;
   }
   
   public void NextTurn()
   {
      if (_currentTurn == PlayerTurn.PlayerOne) _currentTurn = PlayerTurn.PlayerTwo;
      else _currentTurn = PlayerTurn.PlayerOne;
   }
}

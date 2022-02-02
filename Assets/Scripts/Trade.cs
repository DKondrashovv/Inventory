using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Trade : MonoBehaviour
{
  [SerializeField] private Text coinsText;
  public  int Playercoins;
  private void Start()
  {
    
    Playercoins = 100;
  }
  
  

  public  void BuyPlanet()
  {
    Playercoins -= 10;
  }

  public  void SellItem(PlanetTrade planet)
  {
    Playercoins += planet.coins;
  }

  private void Update()
  {
    coinsText.text = Playercoins.ToString();
  }
}

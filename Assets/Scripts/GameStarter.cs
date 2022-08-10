using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private Ship _ship;
    public Ship Ship => _ship;

    [SerializeField] private Transform _startPoint;
    [SerializeField] private GameObject _shipSprite;
    
    void Awake ()
    {
        _ship = StaticShipFactory.CreateShip(ShipType.BigShip);
        
    }
    private void Start()
    {
        Instantiate(_shipSprite, _startPoint);
        PlayerProperty pp = _shipSprite.AddComponent(typeof(PlayerProperty)) as PlayerProperty;
        pp.hp = _ship.Hp;
       
    }


}

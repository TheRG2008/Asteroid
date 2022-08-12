using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private GameObject _shipSprite;
    private Ship _ship;
    public Ship Ship => _ship;
    Bullet _bullet;
    
    void Awake ()
    {
        _ship = StaticShipFactory.CreateShip(ShipType.BigShip);
        _bullet = new StartBullet();
        
    }
    private void Start()
    {

        GameObject ship = Instantiate(_shipSprite, _startPoint);        
        Player player = ship.AddComponent<Player>();        
        ship.AddComponent<SphereCollider>();
        player.HP = _ship.Hp;
        player.Speed = _ship.Speed;
        player.Acceleration = _ship.Acceleration;
        var moveTransform = new AccelerationMove(player.transform.parent, player.Speed, player.Acceleration);
        player.Ship = _ship;
        _ship.GetMove(moveTransform);
        player.Barrel = ship.transform;
        player.Bullet = _bullet.BulletSprite as GameObject;
        player.Force = _bullet.Force;       
        
    }


}

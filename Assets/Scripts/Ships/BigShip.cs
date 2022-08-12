using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigShip : ShipWORotation
{
    private float _hp = 10;
    private float _speed = 2;
    private float _acceleration = 4;
    private GameObject _bullet;
    public BigShip()
    {
        Hp = _hp;
        Speed = _speed;
        Acceleration = _acceleration;
    }
}

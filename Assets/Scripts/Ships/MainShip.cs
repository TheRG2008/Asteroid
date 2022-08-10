using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShip : ShipWithRotation
{
    private readonly float _hp = 5;
    private readonly float _speed = 3;
    private readonly float _acceleration = 5;
    public Transform transform;
    public MainShip ()
    {
        Hp = _hp;
        Speed = _speed;
        Acceleration = _acceleration;       
    }
}

using UnityEngine;

public class Bullet : IBullet
{
    private float _damage;
    private object _bulletSprite;
    private float _force;
    public float Damage 
    { 
        get => _damage; 
        set => _damage = value;
    }
    public object BulletSprite 
    { 
        get => _bulletSprite; 
        set => _bulletSprite = value; 
    }
    public float Force 
    { 
        get => _force; 
        set => _force = value; 
    }
}

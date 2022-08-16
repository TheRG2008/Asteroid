using UnityEngine;

public class StartBullet : Bullet
{
    private float _damage = 1;
    private float _force = 2000f;
    private GameObject _bulletSprite;

    public StartBullet()
    {
        Damage = _damage;
        Force = _force;
        _bulletSprite = Resources.Load("Bullet") as GameObject;
        BulletSprite = _bulletSprite;
        _bulletSprite.AddComponent<BulletDestroy>();
    }
}

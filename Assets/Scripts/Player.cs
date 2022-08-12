using UnityEngine;

internal sealed class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _acceleration;
    [SerializeField] private float _hp;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _barrel;
    [SerializeField] private float _force;
    private Rigidbody2D _bulletRB;
    private Camera _camera;
    private Ship _ship;


    public float Force
    {
        get => _force;
        set => _force = value;
    }
    public Transform Barrel
    {
        get => _barrel;
        set => _barrel = value;
    }
    public GameObject Bullet
    {
        get => _bullet;
        set => _bullet = value;
    }
    public float HP
    {
        get => _hp;
        set => _hp = value;
    }
    public float Acceleration 
    { 
        get => _acceleration; 
        set => _acceleration = value; 
    }
    public float Speed 
    { 
        get => _speed; 
        set => _speed = value; 
    }
    public Ship Ship 
    { 
        get => _ship; 
        set => _ship = value; 
    }

    private void Start()
    {
        _bulletRB = _bullet.GetComponent<Rigidbody2D>();
        _camera = Camera.main;        
        var rotation = new RotationShip(transform);
    }
    void Update()
    {
        var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
        //_ship.Rotation(direction);

        _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

        AccelerationControl();
        Fire();    
    }

    public void AccelerationControl()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Ship.AddAcceleration();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Ship.RemoveAcceleration();
        }
    }

    public void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var temAmmunition = Instantiate(_bulletRB, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _hp--;

        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
       
    }
}

using UnityEngine;

public class Ship : IMove
{
    private readonly IMove _moveImplementation;
     
    private float _acceleration;
    private float _hp;
    private float _speed;


    public float Speed
    {
        private get => _speed;
        set => _speed = value;
    }
    public float Acceleration
    {
        private get => _acceleration;
        set => _acceleration = value;
    }
    public float Hp
    {
        get => _hp;
        set => _hp = value;
    }
    public Ship()
    {
        
    }
    public Ship (IMove moveImplementation)
    {
        _moveImplementation = moveImplementation;
       
    }

    public void Move (float horizontal, float vertical, float deltaTime)
    {
        _moveImplementation.Move(horizontal, vertical, deltaTime);
    }

    

    public void AddAcceleration()
    {
        if (_moveImplementation is AccelerationMove accelerationMove)
        {
            accelerationMove.AddAcceleration();
        }
    }

    public void RemoveAcceleration()
    {
        if (_moveImplementation is AccelerationMove accelerationMove)
        {
            accelerationMove.RemoveAcceleration();
        }
    }
}

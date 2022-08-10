using System;
using UnityEngine;

internal sealed class Bullet : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 2);
        
    }

}

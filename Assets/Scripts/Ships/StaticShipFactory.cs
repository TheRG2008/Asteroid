using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticShipFactory 
{
   
    public static Ship CreateShip()
    {
        return new Ship();
    }

    public static Ship CreateShip (ShipType shipType)
    {
        switch (shipType)
        {
            case ShipType.MainShip:
                return new MainShip();                
            case ShipType.BigShip:
                return new BigShip();
            default:
                return null;
        }
    }
}

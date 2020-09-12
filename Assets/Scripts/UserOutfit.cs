using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserOutfit
{
    private static UserOutfit _instance;

    public Material Outfit { get; private set; }

    public static UserOutfit Instance()
    {
        if(_instance == null)
        {
            _instance = new UserOutfit();
        }

        return _instance;
    }

    public void SetOutfit(Material outfit)
    {
        Outfit = outfit;
    }
}

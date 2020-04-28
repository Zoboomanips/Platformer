using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData
{
    private static int pla1Souls, pla2Souls, pla3Souls;

    public static int Player1Souls
    {
        get
        {
            return pla1Souls;
        }
        set
        {
            pla1Souls = value;
        }
    }

    public static int Player2Souls
    {
        get
        {
            return pla2Souls;
        }
        set
        {
            pla2Souls = value;
        }
    }

    public static int Player3Souls
    {
        get
        {
            return pla3Souls;
        }
        set
        {
            pla3Souls = value;
        }
    }
}
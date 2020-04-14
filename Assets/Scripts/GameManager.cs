using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    protected GameManager() { }

    public int pla1cha = 2;
    public int pla2cha = 1;
    public int pla3cha = 3;
    public int pla4cha = 4;

    public bool pla1ex = true;
    public bool pla2ex = true;
    public bool pla3ex = false;
    public bool pla4ex = false;

}

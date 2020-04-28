using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }

    public int pla1cha = 1;
    public int pla2cha = 1;
    public int pla3cha = 1;

    public bool pla1ex = true;
    public bool pla2ex = true;
    public bool pla3ex = true;

    public bool pla1con = false;
    public bool pla2con = false;
    public bool pla3con = false;

    public float volume = 50;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}



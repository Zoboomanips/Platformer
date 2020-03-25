using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    
    public player Player1;
    public player Player2;
    public player Player3;
    public player Player4;
    // Start is called before the first frame update
    void Start()
    {
        int pla1ch = GameManager.Instance.pla1cha;
        bool pla1e = GameManager.Instance.pla1ex;
        int pla2ch = GameManager.Instance.pla2cha;
        bool pla2e = GameManager.Instance.pla2ex;
        int pla3ch = GameManager.Instance.pla3cha;
        bool pla3e = GameManager.Instance.pla3ex;
        int pla4ch = GameManager.Instance.pla4cha;
        bool pla4e = GameManager.Instance.pla4ex;
        Player1 = new player(1, pla1ch, pla1e);
        Player2 = new player(2, pla2ch, pla2e);
        Player3 = new player(3, pla3ch, pla3e);
        Player4 = new player(4, pla4ch, pla4e);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class player
{
    public int num;
    public int character;
    public int souls;
    public int health;
    public bool exist;

    public player(int n, int c, bool e)
    {
        num = n;
        character = c;
        exist = e;
        health = 100;
        souls = 1;
    }
    public void hit(int val)
    {
        health = health - val;
        if (health <= 0)
        {
            death();
        }
    }

    public void death()
    {
        souls = (int) Mathf.Floor(souls/2) + 1;
        health = 100;
    }

    public void gain(int soul)
    {
        souls += soul;
    }

    public int getChar()
    {
        return character;
    }

}

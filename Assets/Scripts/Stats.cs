using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        player Player1 = new player(1, GameManager.Instance.pla1cha, GameManager.Instance.pla1ex);
        player Player2 = new player(2, GameManager.Instance.pla2cha, GameManager.Instance.pla2ex);
        player Player3 = new player(3, GameManager.Instance.pla3cha, GameManager.Instance.pla3ex);
        player Player4 = new player(4, GameManager.Instance.pla4cha, GameManager.Instance.pla4ex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class player
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
}

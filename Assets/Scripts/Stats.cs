using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    
    public player Player1;
    public player Player2;
    public player Player3;

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;

    public GameObject char1;
    public GameObject char2;
    public GameObject char3;

    public GameObject charPre1;
    public GameObject charPre2;
    public GameObject charPre3;

    public Sprite face1;
    public Sprite face2;
    public Sprite face3;

    public GameObject adio;

    // Start is called before the first frame update
    void Start()
    {
        int pla1ch = GameManager.Instance.pla1cha;
        bool pla1e = GameManager.Instance.pla1ex;
        int pla2ch = GameManager.Instance.pla2cha;
        bool pla2e = GameManager.Instance.pla2ex;
        int pla3ch = GameManager.Instance.pla3cha;
        bool pla3e = GameManager.Instance.pla3ex;
        Player1 = new player(1, pla1ch, pla1e);
        Player2 = new player(2, pla2ch, pla2e);
        Player3 = new player(3, pla3ch, pla3e);

        if (pla1ch == 1)
        {
            char1 = Instantiate(charPre1, new Vector3(3.5f, -3.6f, 0), charPre1.transform.rotation);
            p1.GetComponent<Player_1_move>().face.GetComponent<SpriteRenderer>().sprite = face1;
        } else if (pla1ch == 2)
        {
            char1 = Instantiate(charPre2, new Vector3(3.5f, -3.6f, 0), charPre2.transform.rotation);
            p1.GetComponent<Player_1_move>().face.GetComponent<SpriteRenderer>().sprite = face2;
        } else if (pla1ch == 3)
        {
            char1 = Instantiate(charPre3, new Vector3(3.5f, -3.6f, 0), charPre3.transform.rotation);
            p1.GetComponent<Player_1_move>().face.GetComponent<SpriteRenderer>().sprite = face3;
        }
        p1.GetComponent<Player_1_move>().chara = char1;
        char1.GetComponent<Character_actions>().player = p1;
        char1.GetComponent<Character_actions>().pla = 1;

        if (pla2ch == 1)
        {
            char2 = Instantiate(charPre1, new Vector3(-3.5f, -3.6f, 0), charPre1.transform.rotation);
            p2.GetComponent<Player_2_input>().face.GetComponent<SpriteRenderer>().sprite = face1;
        }
        else if (pla2ch == 2)
        {
            char2 = Instantiate(charPre2, new Vector3(-3.5f, -3.6f, 0), charPre2.transform.rotation);
            p2.GetComponent<Player_2_input>().face.GetComponent<SpriteRenderer>().sprite = face2;
        }
        else if (pla2ch == 3)
        {
            char2 = Instantiate(charPre3, new Vector3(-3.5f, -3.6f, 0), charPre3.transform.rotation);
            p2.GetComponent<Player_2_input>().face.GetComponent<SpriteRenderer>().sprite = face3;
        }
        p2.GetComponent<Player_2_input>().chara = char2;
        char2.GetComponent<Character_actions>().player = p2;
        char2.GetComponent<Character_actions>().pla = 2;

        if (pla3e)
        {
            if (pla3ch == 1)
            {
                char3 = Instantiate(charPre1, new Vector3(0, .5f, 0), charPre1.transform.rotation);
                p3.GetComponent<Player_3_input>().face.GetComponent<SpriteRenderer>().sprite = face1;
            }
            else if (pla3ch == 2)
            {
                char3 = Instantiate(charPre2, new Vector3(0, .5f, 0), charPre1.transform.rotation);
                p3.GetComponent<Player_3_input>().face.GetComponent<SpriteRenderer>().sprite = face2;
            }
            else if (pla3ch == 3)
            {
                char3 = Instantiate(charPre3, new Vector3(0, .5f, 0), charPre1.transform.rotation);
                p3.GetComponent<Player_3_input>().face.GetComponent<SpriteRenderer>().sprite = face3;
            }
            p3.GetComponent<Player_3_input>().chara = char3;
            char3.GetComponent<Character_actions>().player = p3;
            char3.GetComponent<Character_actions>().pla = 3;
        }

        char1.GetComponent<Character_actions>().stats = gameObject;
        char1.GetComponent<Character_actions>().pla1 = p1;
        char1.GetComponent<Character_actions>().pla2 = p2;
        char1.GetComponent<Character_actions>().pla3 = p3;

        char2.GetComponent<Character_actions>().stats = gameObject;
        char2.GetComponent<Character_actions>().pla1 = p1;
        char2.GetComponent<Character_actions>().pla2 = p2;
        char2.GetComponent<Character_actions>().pla3 = p3;

        if (pla3e)
        {
            char3.GetComponent<Character_actions>().stats = gameObject;
            char3.GetComponent<Character_actions>().pla1 = p1;
            char3.GetComponent<Character_actions>().pla2 = p2;
            char3.GetComponent<Character_actions>().pla3 = p3;
        }

        adio.GetComponent<AudioSource>().volume = GameManager.Instance.volume / 100;
        p1.GetComponent<Player_1_move>().control = GameManager.Instance.pla1con;
        p2.GetComponent<Player_2_input>().control = GameManager.Instance.pla2con;
        p3.GetComponent<Player_3_input>().control = GameManager.Instance.pla3con;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1.health <= 0)
        {
            p1.GetComponent<Player_1_move>().Death(Player1.souls - (int)Mathf.Floor(Player1.souls / 2));
            Player1.health = 100;
            Player1.souls = (int)Mathf.Floor(Player1.souls / 2) + 1;
        }
        else if (Player2.health <= 0)
        {
            p2.GetComponent<Player_2_input>().Death(Player2.souls - (int)Mathf.Floor(Player2.souls / 2));
            Player2.health = 100;
            Player2.souls = (int)Mathf.Floor(Player2.souls / 2) + 1;
        }
        else if (Player3.health <= 0)
        {
            p3.GetComponent<Player_3_input>().Death(Player3.souls - (int)Mathf.Floor(Player3.souls / 2));
            Player3.health = 100;
            Player3.souls = (int)Mathf.Floor(Player3.souls / 2) + 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
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
        /*if (health <= 0)
        {
            death();
        }*/
    }

    public void death()
    {
        souls = (int)Mathf.Floor(souls / 2);
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

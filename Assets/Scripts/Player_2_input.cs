using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_input : MonoBehaviour
{
    public GameObject chara;
    public int jumpForce;
    public float walkForce;
    private bool attacking;
    private int attSeq = 1;
    public GameObject stat;
    private int charaNum;
    private bool seqStart;
    private bool spec = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        charaNum = stat.GetComponent<Stats>().Player2.character;

        // move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            chara.GetComponent<SpriteRenderer>().flipX = false;
            chara.GetComponent<Rigidbody2D>().position = new Vector2(chara.GetComponent<Rigidbody2D>().position.x + walkForce, chara.GetComponent<Rigidbody2D>().position.y);
        }

        // move left 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            chara.GetComponent<SpriteRenderer>().flipX = true;
            chara.GetComponent<Rigidbody2D>().position = new Vector2(chara.GetComponent<Rigidbody2D>().position.x - walkForce, chara.GetComponent<Rigidbody2D>().position.y);
        }

        // jump
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (chara.GetComponent<Rigidbody2D>().velocity.y == 0)
            {
                chara.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
            }
        }

        // shield
        if (Input.GetKeyDown(KeyCode.Return))
        {
            chara.GetComponent<Character_actions>().shield();
        }

        // basic attack
        if (Input.GetKey(KeyCode.RightControl))
        {
            if (!attacking)
            {
                plaAttack();
            }

        }

        // special attack
        if (Input.GetKey(KeyCode.RightShift))
        {
            if (!spec)
            {
                plaSpecial();
            }
        }
    }

    public void plaSpecial()
    {
        // Get player attack based on player character
        if (charaNum == 1)
        {
            chara.GetComponent<Character_actions>().special1();
            StartCoroutine(SpecWait(5f));
        }
        if (charaNum == 2)
        {
            chara.GetComponent<Character_actions>().special2();
            StartCoroutine(SpecWait(5f));

        }
        if (charaNum == 3)
        {
            chara.GetComponent<Character_actions>().special2();
            StartCoroutine(SpecWait(5f));

        }
        if (charaNum == 4)
        {
            chara.GetComponent<Character_actions>().special2();
            StartCoroutine(SpecWait(5f));
        }
    }

    public void plaAttack()
    {
        if (attSeq == 1)
        {
            seqStart = true;
            FirstWait(4f);
        }

        // Get player attack based on player character
        if (charaNum == 1)
        {
            chara.GetComponent<Character_actions>().attack1(attSeq);
            StartCoroutine(AttWait(0.05f));
        }
        if (charaNum == 2)
        {
            chara.GetComponent<Character_actions>().attack2(attSeq);
            StartCoroutine(AttWait(0.05f));

        }
        if (charaNum == 3)
        {
            chara.GetComponent<Character_actions>().attack3(attSeq);
            StartCoroutine(AttWait(0.05f));

        }
        if (charaNum == 4)
        {
            chara.GetComponent<Character_actions>().attack4(attSeq);
            StartCoroutine(AttWait(0.05f));

        }

        attSeq++;
        if (attSeq == 5)
        {
            attSeq = 1;
        }
    }

    IEnumerator AttWait(float sec)
    {
        attacking = true;
        yield return new WaitForSeconds(sec);
        attacking = false;
    }

    IEnumerator FirstWait(float sec)
    {
        yield return new WaitForSeconds(sec);
        seqStart = false;
        attSeq = 1;
    }

    IEnumerator SpecWait(float sec)
    {
        spec = true;
        yield return new WaitForSeconds(sec);
        spec = false;
    }
}

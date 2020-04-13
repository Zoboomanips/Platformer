using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_input : MonoBehaviour
{
    public GameObject chara;
    public float jumpforce;
    public float walkForce;
    private bool attacking;
    private int attSeq = 1;
    public GameObject stat;
    private int charaNum;
    private bool seqStart;
    private bool spec = false;
    public GameObject soul;
    private bool jum = false;
    private float prevVel;
    public bool stunned = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (chara.GetComponent<Rigidbody2D>().velocity.y == 0 && prevVel == 0)
        {
            jum = false;
        }
        prevVel = chara.GetComponent<Rigidbody2D>().velocity.y;
        charaNum = stat.GetComponent<Stats>().Player2.character;

        if (!stunned)
        {
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
                if (chara.GetComponent<Rigidbody2D>().velocity.y == 0 || jum == true)
                {
                    if (jum == true)
                    {
                        jum = false;
                    }
                    else
                        jum = true;
                    chara.GetComponent<Rigidbody2D>().velocity = new Vector3(chara.GetComponent<Rigidbody2D>().velocity.x, jumpforce);
                }
            }
            // shield
            if (Input.GetKey(KeyCode.Return))
            {
                chara.GetComponent<Character_actions>().shield();
            }

            // When player releases shield button
            if (Input.GetKeyUp(KeyCode.Return))
            {
                chara.GetComponent<Character_actions>().stopShield();
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
    }

    public void Death(int soulNum)
    {
        for (int i = 0; i < soulNum; i++)
        {
            Instantiate(soul, chara.GetComponent<Rigidbody2D>().transform.position, chara.GetComponent<Rigidbody2D>().transform.rotation);
        }
        chara.GetComponent<SpriteRenderer>().enabled = false;
        StartCoroutine(DeathWait(2.0f));
        chara.transform.position = new Vector3(2.5f, -1.8f, 0);
    }

    IEnumerator DeathWait(float sec)
    {
        yield return new WaitForSeconds(sec);
        chara.GetComponent<SpriteRenderer>().enabled = true;
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
        if (!attacking)
        {
            // Get player attack based on player character
            if (charaNum == 1)
            {
                chara.GetComponent<Character_actions>().attack1(attSeq);
                StartCoroutine(AttWait(0.5f));
            }
            if (charaNum == 2)
            {
                chara.GetComponent<Character_actions>().attack2(attSeq);
                StartCoroutine(AttWait(0.5f));

            }
            if (charaNum == 3)
            {
                chara.GetComponent<Character_actions>().attack3(attSeq);
                StartCoroutine(AttWait(0.5f));

            }
            if (charaNum == 4)
            {
                chara.GetComponent<Character_actions>().attack4(attSeq);
                StartCoroutine(AttWait(0.5f));

            }

            attSeq++;
            if (attSeq == 5)
            {
                attSeq = 1;
            }
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

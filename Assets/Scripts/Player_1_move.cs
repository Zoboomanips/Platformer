using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1_move : MonoBehaviour
{
    // Can we get some documentation please. It'll make things easier for the nonprogrammers.
    public GameObject chara;
    public int jumpforce;
    public float walkforce;
    private bool attacking;
    private int attseq = 1;
    public GameObject stat;
    private int charnum;
    private bool seqst;
    private bool spec = false;
    // Start is called before the first frame update
    void Start()
    {
        //charnum = stat.GetComponent<Stats>().Player1.getChar();
    }

    // Update is called once per frame
    void Update()
    {
        charnum = stat.GetComponent<Stats>().Player1.getChar();
        if (Input.GetKey(KeyCode.S))
		{
            
		}


        if (Input.GetKey(KeyCode.D))
        {
            chara.GetComponent<SpriteRenderer>().flipX = false;
            chara.GetComponent<Rigidbody2D>().position = new Vector2(chara.GetComponent<Rigidbody2D>().position.x + walkforce, chara.GetComponent<Rigidbody2D>().position.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            chara.GetComponent<SpriteRenderer>().flipX = true; 
            chara.GetComponent<Rigidbody2D>().position = new Vector2(chara.GetComponent<Rigidbody2D>().position.x - walkforce, chara.GetComponent<Rigidbody2D>().position.y);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (chara.GetComponent<Rigidbody2D>().velocity.y == 0)
            {
                chara.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpforce);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            chara.GetComponent<Character_actions>().shield();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!attacking)
            {
                plaAttack();
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (!spec)
            {
                plaSpecial();
            }
        }

    }

    public void plaSpecial()
    {
        if (charnum == 1)
        {
            chara.GetComponent<Character_actions>().special1();
            StartCoroutine(SpecWait(5f));
        }
        else if (charnum == 2)
        {
            chara.GetComponent<Character_actions>().special2();
            StartCoroutine(SpecWait(5f));
        }
        else if (charnum == 3)
        {
            chara.GetComponent<Character_actions>().special3();
            StartCoroutine(SpecWait(5f));
        }
        else if (charnum == 4)
        {
            chara.GetComponent<Character_actions>().special4();
            StartCoroutine(SpecWait(5f));
        }
    }


    IEnumerator SpecWait(float sec)
    {
        spec = true;
        yield return new WaitForSeconds(sec);
        spec = false;
    }

    public void plaAttack()
    {
        if (attseq == 1)
        {
            seqst = true;
            FirstWait(4f);
        }
        if(charnum == 1)
        {
            chara.GetComponent<Character_actions>().attack1(attseq);
            StartCoroutine(AttWait(.5f));
        }
        else if (charnum == 2)
        {
            chara.GetComponent<Character_actions>().attack2(attseq);
            StartCoroutine(AttWait(.5f));
        }
        else if (charnum == 3)
        {
            chara.GetComponent<Character_actions>().attack3(attseq);
            StartCoroutine(AttWait(.5f));
        }
        else if (charnum == 4)
        {
            chara.GetComponent<Character_actions>().attack4(attseq);
            StartCoroutine(AttWait(.5f));
        }
        attseq++;
        if (attseq == 5)
        {
            attseq = 1;
            seqst = false;
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
        seqst = false;
        attseq = 1;
    }
}



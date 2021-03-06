﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_3_input : MonoBehaviour
{
    public GameObject chara;
    public float jumpforce;
    public float walkforce;
    private bool attacking;
    private int attseq = 1;
    public GameObject stat;
    private int charnum;
    private bool seqst;
    private bool spec = false;
    public GameObject soul;
    private bool jum = false;
    Animator CharAni;
    private float prevVel;
    public bool stunned = false;
    public GameObject face;
    private Color faceCol;
    public bool control;

    // Start is called before the first frame update
    void Start()
    {
        
        faceCol = face.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        CharAni = chara.GetComponent<Animator>();
        if (chara.GetComponent<Rigidbody2D>().velocity.y == 0 && prevVel == 0)
        {
            jum = false;
        }
        prevVel = chara.GetComponent<Rigidbody2D>().velocity.y;
        charnum = stat.GetComponent<Stats>().Player3.getChar();

        if (chara.transform.position.y < -7)
        {
            stat.GetComponent<Stats>().Player3.hit(100);
        }

        if (!stunned)
        {
            if (control)
            {
                if (Input.GetAxis("Horizontal3") > 0)
                {
                    if (!Input.GetKey(KeyCode.Joystick3Button2))
                    {
                        chara.GetComponent<SpriteRenderer>().flipX = false;
                        chara.GetComponent<Rigidbody2D>().position = new Vector2(chara.GetComponent<Rigidbody2D>().position.x + walkforce, chara.GetComponent<Rigidbody2D>().position.y);
                        if (chara.GetComponent<Rigidbody2D>().velocity.y == 0)
                        {
                            CharAni.SetTrigger("Run");
                        }
                    }
                    else
                    {
                        CharAni.ResetTrigger("Run");
                        CharAni.SetTrigger("Block");
                    }
                }

                // Move left
                if (Input.GetAxis("Horizontal3") < 0)
                {
                    if (!Input.GetKey(KeyCode.Joystick3Button2))
                    {
                        chara.GetComponent<SpriteRenderer>().flipX = true;
                        chara.GetComponent<Rigidbody2D>().position = new Vector2(chara.GetComponent<Rigidbody2D>().position.x - walkforce, chara.GetComponent<Rigidbody2D>().position.y);
                        if (chara.GetComponent<Rigidbody2D>().velocity.y == 0)
                        {
                            CharAni.SetTrigger("Run");
                        }
                    }
                    else
                    {
                        CharAni.ResetTrigger("Run");
                        CharAni.SetTrigger("Block");
                    }

                }

                // If not moving change animation to idle
                if (Input.GetAxis("Horizontal3") > 0 || Input.GetAxis("Horizontal3") < 0)
                {
                    CharAni.SetTrigger("Idle");
                    CharAni.ResetTrigger("Run");
                }

                // If moving up change to jump up animation
                if (chara.GetComponent<Rigidbody2D>().velocity.y > 0)
                {
                    CharAni.SetTrigger("Jump Up");
                }

                // If falling down change to fall down animation
                if (chara.GetComponent<Rigidbody2D>().velocity.y < 0)
                {
                    CharAni.SetTrigger("Jump Down");
                }

                // If not moving horizontally or vertically change to idle animation
                if (chara.GetComponent<Rigidbody2D>().velocity.y == 0 && !(Input.GetAxis("Horizontal3") < 0 || Input.GetAxis("Horizontal3") > 0 || Input.GetKey(KeyCode.Joystick3Button2)))
                {
                    CharAni.SetTrigger("Idle");
                }

                // Jump
                if (Input.GetKeyDown(KeyCode.Joystick3Button0))
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

                // Shield
                if (Input.GetKeyDown(KeyCode.Joystick3Button2))
                {
                    // TODO: Stop Character Movement, also can characters block?
                    chara.GetComponent<Character_actions>().shield();
                    CharAni.SetTrigger("Block");
                    CharAni.ResetTrigger("Idle");
                }

                // When player releases shield button
                if (Input.GetKeyUp(KeyCode.Joystick3Button2))
                {
                    chara.GetComponent<Character_actions>().stopShield();
                }

                // Attack
                if (Input.GetKey(KeyCode.Joystick3Button1))
                {
                    // TODO: How do we do animation? Do we need a script for each character?
                    // TODO: Also need to add an object for the projectiles
                    if (!attacking)
                    {
                        plaAttack();
                    }
                }

                // Special
                if (Input.GetKey(KeyCode.Joystick3Button3))
                {
                    if (!spec)
                    {
                        plaSpecial();
                    }
                }
            }
            else {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    if (!Input.GetKey(KeyCode.RightShift))
                    {
                        chara.GetComponent<SpriteRenderer>().flipX = false;
                        chara.GetComponent<Rigidbody2D>().position = new Vector2(chara.GetComponent<Rigidbody2D>().position.x + walkforce, chara.GetComponent<Rigidbody2D>().position.y);
                        if (chara.GetComponent<Rigidbody2D>().velocity.y == 0)
                        {
                            CharAni.SetTrigger("Run");
                        }
                    }
                    else
                    {
                        CharAni.ResetTrigger("Run");
                        CharAni.SetTrigger("Block");
                    }
                }

                // Move left
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    if (!Input.GetKey(KeyCode.RightShift))
                    {
                        chara.GetComponent<SpriteRenderer>().flipX = true;
                        chara.GetComponent<Rigidbody2D>().position = new Vector2(chara.GetComponent<Rigidbody2D>().position.x - walkforce, chara.GetComponent<Rigidbody2D>().position.y);
                        if (chara.GetComponent<Rigidbody2D>().velocity.y == 0)
                        {
                            CharAni.SetTrigger("Run");
                        }
                    }
                    else
                    {
                        CharAni.ResetTrigger("Run");
                        CharAni.SetTrigger("Block");
                    }

                }

                // If not moving change animation to idle
                if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
                {
                    CharAni.SetTrigger("Idle");
                    CharAni.ResetTrigger("Run");
                }

                // If moving up change to jump up animation
                if (chara.GetComponent<Rigidbody2D>().velocity.y > 0)
                {
                    CharAni.SetTrigger("Jump Up");
                }

                // If falling down change to fall down animation
                if (chara.GetComponent<Rigidbody2D>().velocity.y < 0)
                {
                    CharAni.SetTrigger("Jump Down");
                }

                // If not moving horizontally or vertically change to idle animation
                if (chara.GetComponent<Rigidbody2D>().velocity.y == 0 && !(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightShift)))
                {
                    CharAni.SetTrigger("Idle");
                }

                // Jump
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

                // Shield
                if (Input.GetKeyDown(KeyCode.RightShift))
                {
                    chara.GetComponent<Character_actions>().shield();
                    CharAni.SetTrigger("Block");
                    CharAni.ResetTrigger("Idle");
                }

                // When player releases shield button
                if (Input.GetKeyUp(KeyCode.RightShift))
                {
                    chara.GetComponent<Character_actions>().stopShield();
                }

                // Attack
                if (Input.GetKey(KeyCode.RightControl))
                {
                    if (!attacking)
                    {
                        plaAttack();
                    }
                }

                // Special
                if (Input.GetKey(KeyCode.Return))
                {
                    if (!spec)
                    {
                        plaSpecial();
                    }
                }
            }
        }
    }

    public void Death(int soulNum)
    {
        Vector2 pos = chara.GetComponent<Rigidbody2D>().transform.position;
        chara.GetComponent<SpriteRenderer>().enabled = false;
        StartCoroutine(DeathWait(2.0f));
        chara.transform.position = new Vector3(0, 8f, 0);
        face.GetComponent<SpriteRenderer>().color = Color.grey;
        for (int i = 0; i < soulNum; i++)
        {
            Instantiate(soul, pos, chara.GetComponent<Rigidbody2D>().transform.rotation);
        }
    }

    public void plaSpecial()
    {
        if (charnum == 1)
        {
            CharAni.SetTrigger("Special");
            chara.GetComponent<Character_actions>().special1();
            StartCoroutine(SpecWait(5f));
        }
        else if (charnum == 2)
        {
            CharAni.SetTrigger("Special");
            chara.GetComponent<Character_actions>().special2();
            StartCoroutine(SpecWait(5f));
        }
        else if (charnum == 3)
        {
            CharAni.SetTrigger("Special");
            chara.GetComponent<Character_actions>().special3();
            StartCoroutine(SpecWait(5f));
        }
        else if (charnum == 4)
        {
            CharAni.SetTrigger("Special");
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

    IEnumerator DeathWait(float sec)
    {
        yield return new WaitForSeconds(sec);
        chara.transform.position = new Vector3(0, 2f, 0);
        chara.GetComponent<SpriteRenderer>().enabled = true;
        face.GetComponent<SpriteRenderer>().color = faceCol;
    }

    public void plaAttack()
    {
        if (attseq == 1)
        {
            CharAni.SetTrigger("Attack 1");
            seqst = true;
            FirstWait(4f);
        }
        if (attseq == 2)
        {
            CharAni.SetTrigger("Attack 2");
        }
        if (attseq == 3)
        {
            CharAni.SetTrigger("Attack 3");
        }
        if (attseq == 4)
        {
            CharAni.SetTrigger("Attack 4");
        }
        if (charnum == 1)
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
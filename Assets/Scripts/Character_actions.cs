using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_actions : MonoBehaviour
{
    public GameObject player;
    public int pla;
    public bool def = false;
    public GameObject dag;
    public GameObject fir;
    public GameObject fir4;
    public GameObject firCyc;
    public GameObject stunDag;
    public GameObject stats;
    private Color col;
    public GameObject pla1, pla2, pla3;
    // Start is called before the first frame update
    void Start()
    {
        col = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void hit()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        StartCoroutine(back());
    }

    public void shield()
    {
        def = true;
    }

    public void stopShield()
    {
        def = false;
    }

    public void attack1(int seq)
    {
        Vector2 pla1Pos = new Vector2(pla1.GetComponent<Player_1_move>().chara.transform.position.x, pla1.GetComponent<Player_1_move>().chara.transform.position.y);
        Vector2 pla2Pos = new Vector2(pla2.GetComponent<Player_2_input>().chara.transform.position.x, pla2.GetComponent<Player_2_input>().chara.transform.position.y);
        Vector2 pla3Pos = new Vector2(pla3.GetComponent<Player_3_input>().chara.transform.position.x, pla2.GetComponent<Player_3_input>().chara.transform.position.y);
        if (seq < 4)
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                if (pla == 1)
                {
                    if (pla2Pos.x <= pla1Pos.x && pla2Pos.x >= pla1Pos.x - .9 && pla2Pos.y <= pla1Pos.y + .5 && pla2Pos.y >= pla1Pos.y - .5)
                    {
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player2.hit(20);
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().hit();
                    }
                    if (pla3Pos.x <= pla1Pos.x && pla3Pos.x >= pla1Pos.x - .9 && pla3Pos.y <= pla1Pos.y + .5 && pla3Pos.y >= pla1Pos.y - .5)
                    {
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player3.hit(20);
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().hit();
                    }
                } 
                else if (pla == 2)
                {
                    if (pla1Pos.x <= pla2Pos.x && pla1Pos.x >= pla2Pos.x - .9 && pla1Pos.y <= pla2Pos.y + .5 && pla1Pos.y >= pla2Pos.y - .5)
                    {
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(20);
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().hit();
                    }
                    if (pla3Pos.x <= pla2Pos.x && pla3Pos.x >= pla2Pos.x - .9 && pla3Pos.y <= pla2Pos.y + .5 && pla3Pos.y >= pla2Pos.y - .5)
                    {
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player3.hit(20);
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().hit();
                    }
                }
                else if (pla == 3)
                {
                    if (pla2Pos.x <= pla3Pos.x && pla2Pos.x >= pla3Pos.x - .9 && pla2Pos.y <= pla3Pos.y + .5 && pla2Pos.y >= pla3Pos.y - .5)
                    {
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player2.hit(20);
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().hit();
                    }
                    if (pla1Pos.x <= pla3Pos.x && pla1Pos.x >= pla3Pos.x - .9 && pla1Pos.y <= pla3Pos.y + .5 && pla1Pos.y >= pla3Pos.y - .5)
                    {
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(20);
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().hit();
                    }
                }
            }
            else
            {
                if (pla == 1)
                {
                    if (pla2Pos.x >= pla1Pos.x && pla2Pos.x <= pla1Pos.x + .9 && pla2Pos.y <= pla1Pos.y + .5 && pla2Pos.y >= pla1Pos.y - .5)
                    {
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player2.hit(20);
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().hit();
                    }
                    if (pla3Pos.x >= pla1Pos.x && pla3Pos.x <= pla1Pos.x + .9 && pla3Pos.y <= pla1Pos.y + .5 && pla3Pos.y >= pla1Pos.y - .5)
                    {
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player3.hit(20);
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().hit();
                    }
                }
                else if (pla == 2)
                {
                    if (pla1Pos.x >= pla2Pos.x && pla1Pos.x <= pla2Pos.x + .9 && pla1Pos.y <= pla2Pos.y + .5 && pla1Pos.y >= pla2Pos.y - .5)
                    {
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(20);
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().hit();
                    }
                    if (pla3Pos.x >= pla2Pos.x && pla3Pos.x <= pla2Pos.x + .9 && pla3Pos.y <= pla2Pos.y + .5 && pla3Pos.y >= pla2Pos.y - .5)
                    {
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player3.hit(20);
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().hit();
                    }
                }
                else if (pla == 3)
                {
                    if (pla2Pos.x >= pla3Pos.x && pla2Pos.x <= pla3Pos.x + .9 && pla2Pos.y <= pla3Pos.y + .5 && pla2Pos.y >= pla3Pos.y - .5)
                    {
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player2.hit(20);
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().hit();
                    }
                    if (pla1Pos.x >= pla3Pos.x && pla1Pos.x <= pla3Pos.x + .9 && pla1Pos.y <= pla3Pos.y + .5 && pla1Pos.y >= pla3Pos.y - .5)
                    {
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(20);
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().hit();
                    }
                }
            }
        }
        else
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                if (pla == 1)
                {
                    if (pla2Pos.x <= pla1Pos.x && pla2Pos.x >= pla1Pos.x - 1.4 && pla2Pos.y <= pla1Pos.y + .5 && pla2Pos.y >= pla1Pos.y - .5)
                    {
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(1, pla2.GetComponent<Player_2_input>().chara));
                    }
                    if (pla3Pos.x <= pla1Pos.x && pla3Pos.x >= pla1Pos.x - 1.4 && pla3Pos.y <= pla1Pos.y + .5 && pla3Pos.y >= pla1Pos.y - .5)
                    {
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(1, pla3.GetComponent<Player_3_input>().chara));
                    }
                }
                else if (pla == 2)
                {
                    if (pla1Pos.x <= pla2Pos.x && pla1Pos.x >= pla2Pos.x - 1.4 && pla1Pos.y <= pla2Pos.y + .5 && pla1Pos.y >= pla2Pos.y - .5)
                    {
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(1, pla1.GetComponent<Player_1_move>().chara));
                    }
                    if (pla3Pos.x <= pla2Pos.x && pla3Pos.x >= pla2Pos.x - 1.4 && pla3Pos.y <= pla2Pos.y + .5 && pla3Pos.y >= pla2Pos.y - .5)
                    {
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(1, pla3.GetComponent<Player_3_input>().chara));
                    }
                }
                else if (pla == 3)
                {
                    if (pla2Pos.x <= pla3Pos.x && pla2Pos.x >= pla3Pos.x - 1.4 && pla2Pos.y <= pla3Pos.y + .5 && pla2Pos.y >= pla3Pos.y - .5)
                    {
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(1, pla2.GetComponent<Player_2_input>().chara));
                    }
                    if (pla1Pos.x <= pla3Pos.x && pla1Pos.x >= pla3Pos.x - 1.4 && pla1Pos.y <= pla3Pos.y + .5 && pla1Pos.y >= pla3Pos.y - .5)
                    {
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(1, pla1.GetComponent<Player_1_move>().chara));
                    }
                }
            }
            else
            {
                if (pla == 1)
                {
                    if (pla2Pos.x >= pla1Pos.x && pla2Pos.x <= pla1Pos.x + 1.4 && pla2Pos.y <= pla1Pos.y + .5 && pla2Pos.y >= pla1Pos.y - .5)
                    {
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(-1, pla2.GetComponent<Player_2_input>().chara));
                    }
                    if (pla3Pos.x >= pla1Pos.x && pla3Pos.x <= pla1Pos.x + 1.4 && pla3Pos.y <= pla1Pos.y + .5 && pla3Pos.y >= pla1Pos.y - .5)
                    {
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(-1, pla3.GetComponent<Player_3_input>().chara));
                    }
                }
                else if (pla == 2)
                {
                    if (pla1Pos.x >= pla2Pos.x && pla1Pos.x <= pla2Pos.x + 1.4 && pla1Pos.y <= pla2Pos.y + .5 && pla1Pos.y >= pla2Pos.y - .5)
                    {
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(-1, pla1.GetComponent<Player_1_move>().chara));
                    }
                    if (pla3Pos.x >= pla2Pos.x && pla3Pos.x <= pla2Pos.x + 1.4 && pla3Pos.y <= pla2Pos.y + .5 && pla3Pos.y >= pla2Pos.y - .5)
                    {
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla3.GetComponent<Player_3_input>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(-1, pla3.GetComponent<Player_3_input>().chara));
                    }
                }
                else if (pla == 3)
                {
                    if (pla2Pos.x >= pla3Pos.x && pla2Pos.x <= pla3Pos.x + 1.4 && pla2Pos.y <= pla3Pos.y + .5 && pla2Pos.y >= pla3Pos.y - .5)
                    {
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla2.GetComponent<Player_2_input>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(-1, pla2.GetComponent<Player_2_input>().chara));
                    }
                    if (pla1Pos.x >= pla3Pos.x && pla1Pos.x <= pla3Pos.x + 1.4 && pla1Pos.y <= pla3Pos.y + .5 && pla1Pos.y >= pla3Pos.y - .5)
                    {
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
                        pla1.GetComponent<Player_1_move>().chara.GetComponent<Character_actions>().hit();
                        StartCoroutine(pull(-1, pla1.GetComponent<Player_1_move>().chara));
                    }
                }
            }
        }
    }

    public void special1()
    {
        if (gameObject.GetComponent<SpriteRenderer>().flipX)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-400.0f, 0));
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(400.0f, 0));
        }
    }

    public void attack2(int seq)
    {
        if (seq < 4)
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                StartCoroutine(Att2(.2f, true));
            }
            else
            {
                StartCoroutine(Att2(.2f, false));
            }
        }
        else
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                StartCoroutine(Att24(.2f, true));
            }
            else
            {
                StartCoroutine(Att24(.2f, false));
            }
        }
    }

    public void special2()
    {
        if (gameObject.GetComponent<SpriteRenderer>().flipX)
        {
            StartCoroutine(Spec2(1f, true));
        }
        else
        {
            StartCoroutine(Spec2(1f, false));
        }
    }

    public void attack3(int seq)
    {
        if (seq < 4)
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                StartCoroutine(Att3(.2f, true));
            }
            else
            {
                StartCoroutine(Att3(.2f, false));
            }
        }
        else
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                StartCoroutine(Att34(.2f, true));
            }
            else
            {
                StartCoroutine(Att34(.2f, false));
            }
        }
    }

    public void special3()
    {
        if (gameObject.GetComponent<SpriteRenderer>().flipX)
        {
            StartCoroutine(Spec3(true));
        }
        else
        {
            StartCoroutine(Spec3(false));
        }
    }

    public void attack4(int seq)
    {

    }

    public void special4()
    {

    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
    }

    IEnumerator back()
    {
        yield return new WaitForSeconds(.2f);
        gameObject.GetComponent<SpriteRenderer>().color = col;
    }

    IEnumerator pull(int x, GameObject player)
    {
        yield return new WaitForSeconds(.5f);
        player.GetComponent<Rigidbody2D>().AddForce(new Vector2(x * 100, 0));
    }

    IEnumerator Att2(float sec, bool flip)
    {
        yield return new WaitForSeconds(sec);
        GameObject dagg = Instantiate(dag, new Vector3(gameObject.GetComponent<Rigidbody2D>().transform.position.x, gameObject.GetComponent<Rigidbody2D>().transform.position.y), gameObject.GetComponent<Rigidbody2D>().transform.rotation);
        dagg.GetComponent<Dagger>().pla = pla;
        dagg.GetComponent<SpriteRenderer>().flipX = flip;
    }

    IEnumerator Att24(float sec, bool flip)
    {
        yield return new WaitForSeconds(sec);
        GameObject dag1 = Instantiate(dag, new Vector3(gameObject.GetComponent<Rigidbody2D>().transform.position.x, gameObject.GetComponent<Rigidbody2D>().transform.position.y), gameObject.GetComponent<Rigidbody2D>().transform.rotation);
        dag1.GetComponent<Dagger>().pla = pla;
        dag1.GetComponent<SpriteRenderer>().flipX = flip;
        GameObject dag2 = Instantiate(dag, new Vector3(gameObject.GetComponent<Rigidbody2D>().transform.position.x, gameObject.GetComponent<Rigidbody2D>().transform.position.y + 0.1f), gameObject.GetComponent<Rigidbody2D>().transform.rotation);
        dag2.GetComponent<Dagger>().pla = pla;
        dag2.GetComponent<SpriteRenderer>().flipX = flip;
    }

    IEnumerator Spec2(float sec, bool flip)
    {
        yield return new WaitForSeconds(sec);
        Instantiate(stunDag, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation).GetComponent<SpriteRenderer>().flipX = flip;
    }


    IEnumerator Att3(float sec, bool flip)
    {
        yield return new WaitForSeconds(sec);
        GameObject fire = Instantiate(fir, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation);
        fire.GetComponent<Fireball>().pla = pla;
        fire.GetComponent<SpriteRenderer>().flipX = flip;
    }

    IEnumerator Att34(float sec, bool flip)
    {
        yield return new WaitForSeconds(sec);
        GameObject fire = Instantiate(fir4, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation);
        fire.GetComponent<Fireball_4>().pla = pla;
        fire.GetComponent<SpriteRenderer>().flipX = flip;
    }

    IEnumerator Spec3(bool flip)
    {
        yield return new WaitForSeconds(0);
        GameObject fire = Instantiate(firCyc, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation);
        fire.GetComponent<Fire_Cyclone>().pla = pla;
        fire.GetComponent<SpriteRenderer>().flipX = flip;
    }
}

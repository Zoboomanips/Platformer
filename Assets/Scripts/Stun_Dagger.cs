using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun_Dagger : MonoBehaviour
{
    public float dir;
    private bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        if (gameObject.GetComponent<SpriteRenderer>().flipX)
            dir = -1;
        else
            dir = 1;
        StartCoroutine(Wait(.2f));
    }

    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            gameObject.transform.position = new Vector2((gameObject.transform.position.x + (dir * 0.1f)), gameObject.transform.position.y);
        }
        if (gameObject.transform.position.x >= 5 || gameObject.transform.position.x <= -5)
        {
            DestroyObject(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.gameObject.GetComponent<Character_actions>().pla == 1 && !coll.collider.gameObject.GetComponent<Character_actions>().def)
        {
            coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(10);
            coll.collider.gameObject.GetComponent<Character_actions>().player.GetComponent<Player_1_move>().stunned = true;
            StartCoroutine(StunWait(1f, coll.collider.gameObject.GetComponent<Character_actions>().player, 1));
        }
        if (coll.collider.gameObject.GetComponent<Character_actions>().pla == 2 && !coll.collider.gameObject.GetComponent<Character_actions>().def)
        {
            coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player2.hit(10);
            coll.collider.gameObject.GetComponent<Character_actions>().player.GetComponent<Player_2_input>().stunned = true;
            StartCoroutine(StunWait(1f, coll.collider.gameObject.GetComponent<Character_actions>().player, 2));
        }
        done = true;
    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    IEnumerator StunWait(float sec, GameObject player, int pla)
    {
        yield return new WaitForSeconds(sec);
        if (pla == 1)
        {
            player.GetComponent<Player_1_move>().stunned = false;
        }
        if (pla == 2)
        {
            player.GetComponent<Player_2_input>().stunned = false;
        }
        DestroyObject(gameObject);
    }
}
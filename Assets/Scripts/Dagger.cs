using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : MonoBehaviour
{
    public float dir;
    public int pla;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        if (gameObject.GetComponent<SpriteRenderer>().flipX)
            dir = -1;
        else
            dir = 1;
        StartCoroutine(Wait(.05f));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2((gameObject.transform.position.x + (dir * 0.1f)), gameObject.transform.position.y);
        if (gameObject.transform.position.x >= 7 || gameObject.transform.position.x <= -7)
        {
            DestroyObject(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (pla != coll.collider.gameObject.GetComponent<Character_actions>().pla)
        {
            if (coll.collider.gameObject.GetComponent<Character_actions>().pla == 1 && !coll.collider.gameObject.GetComponent<Character_actions>().def)
            {
                coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(15);
                coll.collider.gameObject.GetComponent<Character_actions>().hit();
            }
            if (coll.collider.gameObject.GetComponent<Character_actions>().pla == 2 && !coll.collider.gameObject.GetComponent<Character_actions>().def)
            {
                coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player2.hit(15);
                coll.collider.gameObject.GetComponent<Character_actions>().hit();
            }
            DestroyObject(gameObject);
        }
    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}




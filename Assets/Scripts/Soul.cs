using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soul : MonoBehaviour
{
    private Color baseCol;
    // Start is called before the first frame update
    void Start()
    {
        baseCol = gameObject.GetComponent<SpriteRenderer>().color;
        StartCoroutine(Delay1(10));
        StartCoroutine(Destroy(15));
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -7)
        {
            DestroyObject(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.gameObject.GetComponent<Character_actions>().pla == 1)
        {
            coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.gain(1);
        }
        if (coll.collider.gameObject.GetComponent<Character_actions>().pla == 2)
        {
            coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player2.gain(1);
        }
        if (coll.collider.gameObject.GetComponent<Character_actions>().pla == 3)
        {
            coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player3.gain(1);
        }
        DestroyObject(gameObject);
    }

    IEnumerator Destroy(float sec)
    {
        yield return new WaitForSeconds(sec);
        DestroyObject(gameObject);
    }

    IEnumerator Delay1(float sec)
    {
        yield return new WaitForSeconds(sec);
        gameObject.GetComponent<SpriteRenderer>().color = Color.clear;
        StartCoroutine(Delay2(.4f));
    }

    IEnumerator Delay2(float sec)
    {
        yield return new WaitForSeconds(sec);
        gameObject.GetComponent<SpriteRenderer>().color = baseCol;
        StartCoroutine(Delay1(.4f));
    }
}

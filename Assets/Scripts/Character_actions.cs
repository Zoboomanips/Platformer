using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_actions : MonoBehaviour
{
    public GameObject player;
    public int pla;
    public bool def = false;
    public GameObject dag;
    public GameObject stunDag;
    public GameObject stats;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
        if (seq < 4)
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                
            }
            else
            {
                
            }
        }
        else
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                
            }
            else
            {
                
            }
        }
    }

    public void special1()
    {

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

    }

    public void special3()
    {

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

    IEnumerator Att2(float sec, bool flip)
    {
        yield return new WaitForSeconds(sec);
        Instantiate(dag, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation).GetComponent<SpriteRenderer>().flipX = flip;
    }

    IEnumerator Att24(float sec, bool flip)
    {
        yield return new WaitForSeconds(sec);
        Instantiate(dag, new Vector3(gameObject.GetComponent<Rigidbody2D>().transform.position.x, gameObject.GetComponent<Rigidbody2D>().transform.position.y), gameObject.GetComponent<Rigidbody2D>().transform.rotation).GetComponent<SpriteRenderer>().flipX = flip;
        Instantiate(dag, new Vector3(gameObject.GetComponent<Rigidbody2D>().transform.position.x, gameObject.GetComponent<Rigidbody2D>().transform.position.y + 0.1f), gameObject.GetComponent<Rigidbody2D>().transform.rotation).GetComponent<SpriteRenderer>().flipX = flip;
    }

    IEnumerator Spec2(float sec, bool flip)
    {
        yield return new WaitForSeconds(sec);
        Instantiate(stunDag, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation).GetComponent<SpriteRenderer>().flipX = flip;
    }
}

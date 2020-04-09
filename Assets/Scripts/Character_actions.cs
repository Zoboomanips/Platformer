using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_actions : MonoBehaviour
{
    public GameObject player;
    public int pla;
    public bool def = false;
    public GameObject dag;
    public GameObject stats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        def = false;
    }

    public void shield()
    {
        def = true;
    }

    public void attack1(int seq)
    {

    }

    public void special1()
    {

    }

    public void attack2(int seq)
    {
        if(seq < 4)
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                Instantiate(dag, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation).GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                Instantiate(dag, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation);
            }
        } 
        else
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                Instantiate(dag, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation).GetComponent<SpriteRenderer>().flipX = true;
                StartCoroutine(Wait(.1f));
                Instantiate(dag, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation).GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                Instantiate(dag, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation);
                StartCoroutine(Wait(.1f));
                Instantiate(dag, gameObject.GetComponent<Rigidbody2D>().transform.position, gameObject.GetComponent<Rigidbody2D>().transform.rotation);
            }
        }
    }

    public void special2()
    {
        if (gameObject.GetComponent<SpriteRenderer>().flipX) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-400.0f, 0));
        } else
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(400.0f, 0));
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Cyclone : MonoBehaviour
{
    public float dir;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait(1f));
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.gameObject.GetComponent<Character_actions>().pla == 1 && !coll.collider.gameObject.GetComponent<Character_actions>().def)
        {
            coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player1.hit(30);
            coll.collider.gameObject.GetComponent<Character_actions>().hit();
        }
        if (coll.collider.gameObject.GetComponent<Character_actions>().pla == 2 && !coll.collider.gameObject.GetComponent<Character_actions>().def)
        {
            coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player2.hit(30);
            coll.collider.gameObject.GetComponent<Character_actions>().hit();
        }
        DestroyObject(gameObject);
    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
        DestroyObject(gameObject);
    }
}

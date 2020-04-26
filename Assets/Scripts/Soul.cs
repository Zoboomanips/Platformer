using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soul : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        else
        {
            coll.collider.gameObject.GetComponent<Character_actions>().stats.GetComponent<Stats>().Player2.gain(1);
        }
        DestroyObject(gameObject);
    }
}

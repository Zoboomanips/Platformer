using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Cyclone : MonoBehaviour
{
    public float dir;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        // How to destroy object once the animation is over?
        //DestroyObject(gameObject);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
       
    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}

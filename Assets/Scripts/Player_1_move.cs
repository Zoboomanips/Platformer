using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1_move : MonoBehaviour
{
    public GameObject chara;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (true/*move right button*/)
        {
            //move
        }
        if (true/*move left button*/)
        {
            //move
        }
        if (true/*jump button*/)
        {
            //jump
        }
        if (true/*shield button*/)
        {
            //shield
        }

        if (true/*attack button*/)
        {
            plaAttack(); 
        }

    }

    public void plaAttack()
    {
        //chara.attack(1);
    }
}

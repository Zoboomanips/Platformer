using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    public GameObject stat;
    string pl1s, pl1h, pl2s, pl2h;
    UnityEngine.UI.Text pl1st, pl1ht, pl2st, pl2ht;
    // Start is called before the first frame update
    void Start()
    {
        //pl1s = stat.GetComponent<Stats>().Player1.souls.ToString() + " souls";
        //pl1h = stat.GetComponent<Stats>().Player1.health.ToString() + " health";
        //pl2s = stat.GetComponent<Stats>().Player2.souls.ToString() + " souls";
        //pl2h = stat.GetComponent<Stats>().Player2.health.ToString() + " health";

        Transform child1 = transform.Find("Player1Souls");
        pl1st = child1.GetComponent<UnityEngine.UI.Text> ();
        Transform child2 = transform.Find("Player1Health");
        pl1ht = child2.GetComponent<UnityEngine.UI.Text>();
        Transform child3 = transform.Find("Player2Souls");
        pl2st = child3.GetComponent<UnityEngine.UI.Text>();
        Transform child4 = transform.Find("Player2Health");
        pl2ht = child4.GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pl1s = stat.GetComponent<Stats>().Player1.souls.ToString() + " souls";
        pl1h = stat.GetComponent<Stats>().Player1.health.ToString() + " health";
        pl2s = stat.GetComponent<Stats>().Player2.souls.ToString() + " souls";
        pl2h = stat.GetComponent<Stats>().Player2.health.ToString() + " health";

        pl1st.text = pl1s;
        pl1ht.text = pl1h;
        pl2st.text = pl2s;
        pl2ht.text = pl2h;
    }
}

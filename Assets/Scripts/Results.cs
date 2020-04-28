using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Results : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Text pl1st;
    [SerializeField] private UnityEngine.UI.Text pl2st;
    [SerializeField] private UnityEngine.UI.Text pl3st;
    [SerializeField] private UnityEngine.UI.Text pl1win;
    [SerializeField] private UnityEngine.UI.Text pl2win;
    [SerializeField] private UnityEngine.UI.Text pl3win;

    // Start is called before the first frame update
    void Start()
    {
        int max = findMax(PlayerData.Player1Souls, PlayerData.Player2Souls, PlayerData.Player3Souls);
        if (max == PlayerData.Player1Souls)
        {
            pl1win.gameObject.SetActive(true);
        } else
        {
            pl1win.gameObject.SetActive(false);
        }
        if (max == PlayerData.Player2Souls)
        {
            pl2win.gameObject.SetActive(true);
        } else
        {
            pl2win.gameObject.SetActive(false);
        }
        if (max == PlayerData.Player2Souls)
        {
            pl3win.gameObject.SetActive(true);
        } else
        {
            pl3win.gameObject.SetActive(false);
        }
        pl1st.text = PlayerData.Player1Souls.ToString();
        pl2st.text = PlayerData.Player2Souls.ToString();
        pl3st.text = PlayerData.Player3Souls.ToString();
    }

    int findMax(int pla1, int pla2, int pla3)
    {
        int max = System.Math.Max(pla1, pla2);
        max = System.Math.Max(max, pla3);
        return max;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    bool Player1Control = false;
    bool Player2Control = false;
    float volume = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1Toggle()
    {
        Player1Control = !Player1Control;
    }

    public void Player2Toggle()
    {
        Player2Control = !Player2Control;
    }

    public void AdjustVolume(float newVol)
    {
        volume = newVol;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Done()
    {
        Application.Quit();
    }
    public void Disable1(Image background, UnityEngine.UI.Text player, Image img)
    {
        background.color = new Color(0f, 0f, 0f);
        player.text = "N/A";
        img.sprite = null;
    }

    public void Open(int num)
    {
        SceneManager.LoadScene(num);
    }

    public void DisableBackground(Image background)
    {
        background.color = new Color(0f, 0f, 0f);
    }
    public void DisableImage(Image img)
    {
        img.enabled = false;
    }
    public void DisableText(UnityEngine.UI.Text player)
    {
        player.text = "N/A"; 
    }

    public void DisableName(UnityEngine.UI.Text player)
    {
        player.text = "";
    }

    public void DisableButton(UnityEngine.UI.Button but)
    {
        but.interactable = false;
    }

    public void EnableButton(UnityEngine.UI.Button but)
    {
        but.interactable = true;
    }
}

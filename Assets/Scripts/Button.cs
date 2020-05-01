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

    public void Left(int pla)
    {
        if (pla == 1)
        {
            GameManager.Instance.pla1cha -= 1;
            if (GameManager.Instance.pla1cha == 0)
                GameManager.Instance.pla1cha = 3;
        }
        if (pla == 2)
        {
            GameManager.Instance.pla2cha -= 1;
            if (GameManager.Instance.pla2cha == 0)
                GameManager.Instance.pla2cha = 3;
        }
        if (pla == 3)
        {
            GameManager.Instance.pla3cha -= 1;
            if (GameManager.Instance.pla3cha == 0)
                GameManager.Instance.pla3cha = 3;
        }
    }
    public void Right(int pla)
    {
        if (pla == 1)
        {
            GameManager.Instance.pla1cha += 1;
            if (GameManager.Instance.pla1cha == 4)
                GameManager.Instance.pla1cha = 1;
        }
        if (pla == 2)
        {
            GameManager.Instance.pla2cha += 1;
            if (GameManager.Instance.pla2cha == 4)
                GameManager.Instance.pla2cha = 1;
        }
        if (pla == 3)
        {
            GameManager.Instance.pla3cha += 1;
            if (GameManager.Instance.pla3cha == 4)
                GameManager.Instance.pla3cha = 1;
        }
    }

    public void Keyboard(int pla)
    {
        if (GameManager.Instance.pla1con)
            GameManager.Instance.pla1con = false;
        else
            GameManager.Instance.pla1con = true;

        if (GameManager.Instance.pla2con)
            GameManager.Instance.pla2con = false;
        else
            GameManager.Instance.pla2con = true;

        if (GameManager.Instance.pla3con)
            GameManager.Instance.pla3con = false;
        else
            GameManager.Instance.pla3con = true;
    }

}

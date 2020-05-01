using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    private int selectedCharacterIndex;
    private Color desiredColor;

    [SerializeField] private List<CharacterSelectObject> characterList = new List<CharacterSelectObject>();

    [SerializeField] private UnityEngine.UI.Text characterName;
    [SerializeField] private Image characterSplash;
    [SerializeField] private Image backgroundColor;

    void Start()
    {
        UpdateCharacterSelectionUI();
    }
    
    private void UpdateCharacterSelectionUI()
    {
        // Splash, Name, Desired Color
        characterSplash.sprite = characterList[selectedCharacterIndex].splash;
        if (selectedCharacterIndex == 0)
        {
            characterSplash.rectTransform.localScale = new Vector3(1f, 0.5f, 1f);
        } else
        {
            characterSplash.rectTransform.localScale = new Vector3(0.5f, 0.5f, 1f);
        }
        characterName.text = characterList[selectedCharacterIndex].characterName;
        desiredColor = characterList[selectedCharacterIndex].characterColor;
    }

    public void LeftArrow()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0)
        {
            selectedCharacterIndex = characterList.Count - 1;
        }
        UpdateCharacterSelectionUI();
    }

    public void RightArrow()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex == characterList.Count)
        {
            selectedCharacterIndex = 0;
        }
        UpdateCharacterSelectionUI();
    }

    public void EnableBackground(Image background)
    {
        background.color = new Color(0f, 255f, 0f, 130f);
    }
    public void EnableImage(Image img)
    {
        img.enabled = true;
    }
    public void EnableText(UnityEngine.UI.Text player)
    {
        player.text = "3 P";
    }

    public void EnableName(UnityEngine.UI.Text player)
    {
        player.text = characterList[selectedCharacterIndex].characterName;
    }

    [System.Serializable]
    public class CharacterSelectObject
    {
        public Sprite splash;
        public string characterName;
        public Color characterColor;
    }
}

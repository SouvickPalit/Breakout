using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour

{
    public Button[] levelButtons;
    public int levelunlocked = 1;
    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", levelunlocked);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }
    }
}

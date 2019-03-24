using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button[] levelButtons;
    public int levelunlocked = 1;
    public void unlock()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", levelunlocked);
        for (int i = 0; i <= levelReached; i++)
        {
            levelButtons[i].interactable = false;
        }
    }
}

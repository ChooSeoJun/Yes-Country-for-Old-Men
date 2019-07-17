using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class CharacterManager : ScriptableObject
{

    public static CharacterManager instance;

    public int Day = 1;
    public int hungry=50;
    public int mental=100;
    public int Temperature=100;
    public int houseQuality=100;
    public int tired=0;

    public CharacterManager()
    {
        Day = 1;
        hungry = 50;
        mental = 100;
        Temperature = 100;
        houseQuality = 100;
        tired = 0;
}


    public static CharacterManager Get_instance()
    {
        if (instance == null)
        {
            instance = CreateInstance<CharacterManager>();
        }

        return instance;
    }

    public static  void EndGame()
    {
        if(Get_instance().Day>30)
        {
            SceneManager.LoadScene("HappyEnding");
        }
        SceneManager.LoadScene(CharacterManager.Get_instance().CheckStat() ? "Main" : "SadEnding");

        CharacterManager.Get_instance().Day += 1;
        CharacterManager.Get_instance().hungry -= 10;
        CharacterManager.Get_instance().mental -= 10;
        CharacterManager.Get_instance().Temperature -= 10;
        CharacterManager.Get_instance().houseQuality -= 10;
        CharacterManager.Get_instance().tired += 10;
        
    }

    bool CheckStat()
    {
        if(tired == 100 || mental == 0 || houseQuality == 0 || Temperature == 0 || hungry == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

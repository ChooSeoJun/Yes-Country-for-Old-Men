using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : SceneScript
{
    
    public void GoTitle()
    {
        CharacterManager.Get_instance().Day = 1;
        CharacterManager.Get_instance().hungry = 50;
        CharacterManager.Get_instance().mental = 100;
        CharacterManager.Get_instance().Temperature = 100;
        CharacterManager.Get_instance().houseQuality = 100;
        CharacterManager.Get_instance().tired = 0;
        ChangeScene("Title");
    }
}

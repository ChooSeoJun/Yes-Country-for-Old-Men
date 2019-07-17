using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseMiniGame : SceneScript
{
   
    public void PlayingCoalBriquette()
    {
        ChangeScene("CoalBriquette");
    }

    public void PlayingFixHouse()
    {
        ChangeScene("FixHouse");
    }

    public void PlayingMakingRice()
    {
        ChangeScene("MakingRice");
    }

    public void PlayingMassage()
    {
        ChangeScene("Massage");
    }

    public void PlayingPlayingDance()
    {
        ChangeScene("Dancing");
    }
}

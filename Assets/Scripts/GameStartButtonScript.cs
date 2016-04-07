using UnityEngine;
using System.Collections;

public class GameStartButtonScript : MonoBehaviour
{

    public void ToStage1()
    {
        Application.LoadLevel("Stage1");
    }
    public void ToStage2()
    {
        Application.LoadLevel("Stage2");
    }
    public void ToStage3()
    {
        Application.LoadLevel("Stage3");
    }
    public void ToStageBoss()
    {
        Application.LoadLevel("BossStage");
    }
    public void ToStory()
    {
        Application.LoadLevel("Story");
    }
}

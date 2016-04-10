using UnityEngine;
using System.Collections;

public class MiniGameButton : MonoBehaviour {

    public void ToTitle()
    {
        Application.LoadLevel("Title");
    }
    public void ToRetry()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void ToMiniGameRoll()
    {
        Application.LoadLevel("MiniGameRoll");
    }
    public void ToMiniGameFree()
    {
        Application.LoadLevel("MiniGameFree");
    }
    public void ToMiniGameTutorial()
    {
        Application.LoadLevel("MiniGameTutorial");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public string Link;

    public void LeaveGame()
    {
        Application.Quit();
    }

    public void OpenLink()
    {
        Application.OpenURL(Link);
    }
}

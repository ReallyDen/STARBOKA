using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSwitcher : MonoBehaviour
{
    public GameObject firstBg;
    public GameObject secondBg;
    public GameObject thirdBg;
    public GameObject fourthBg;
    public GameObject fifthBg;
    public GameObject sixthBg;

    public void OpenFirstBg()
    {
        firstBg.SetActive(true);
        secondBg.SetActive(false);
        thirdBg.SetActive(false);
        fourthBg.SetActive(false);
        fifthBg.SetActive(false);
        sixthBg.SetActive(false);
    }
    public void OpenSecondBg()
    {
        firstBg.SetActive(false);
        secondBg.SetActive(true);
        thirdBg.SetActive(false);
        fourthBg.SetActive(false);
        fifthBg.SetActive(false);
        sixthBg.SetActive(false);
    }
    public void OpenThirdBg()
    {
        firstBg.SetActive(false);
        secondBg.SetActive(false);
        thirdBg.SetActive(true);
        fourthBg.SetActive(false);
        fifthBg.SetActive(false);
        sixthBg.SetActive(false);
    }
    public void OpenFourthBg()
    {
        firstBg.SetActive(false);
        secondBg.SetActive(false);
        thirdBg.SetActive(false);
        fourthBg.SetActive(true);
        fifthBg.SetActive(false);
        sixthBg.SetActive(false);
    }
    public void OpenFifthBg()
    {
        firstBg.SetActive(false);
        secondBg.SetActive(false);
        thirdBg.SetActive(false);
        fourthBg.SetActive(false);
        fifthBg.SetActive(true);
        sixthBg.SetActive(false);
    }
    public void OpenSixthBg()
    {
        firstBg.SetActive(false);
        secondBg.SetActive(false);
        thirdBg.SetActive(false);
        fourthBg.SetActive(false);
        fifthBg.SetActive(false);
        sixthBg.SetActive(true);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Language : MonoBehaviour
{
    public int language;

    void Start()
    {
        language = PlayerPrefs.GetInt("language", language);
    }

    void Update()
    {

    }

    public void EnglishLanguage()
    {
        language = 0;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RussianLanguage()
    {
        language = 1;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasButton : MonoBehaviour
{
    public Sprite musicOn, musicOff;

    private void Start()
    {
        if (PlayerPrefs.GetString("music") == "No" && gameObject.name == "Sound")
        {
            GetComponent<Image>().sprite = musicOff;
        }
    }

    public void LoadGitHub()
    {
        if (PlayerPrefs.GetString("music") != "No")
        {
            GetComponent<AudioSource>().Play();
            StartCoroutine(LoadURL());
        }
        else
        {
            Application.OpenURL("https://github.com/Xomyak-ammiak/SpaceGame");
        }
        IEnumerator LoadURL()
        {
            yield return new WaitForSeconds(0.3f);
            Application.OpenURL("https://github.com/Xomyak-ammiak/SpaceGame");
        }
    }

    public void LoadGame1()
    {
        if (PlayerPrefs.GetString("music") != "No")
        {
            GetComponent<AudioSource>().Play();
            StartCoroutine(RestartGameIE1());
        }
        else
        {
            SceneManager.LoadScene("Game1");

        }
        IEnumerator RestartGameIE1()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("Game1");
        }
    }

    public void LoadGame2()
    {
        if (PlayerPrefs.GetString("music") != "No")
        {
            GetComponent<AudioSource>().Play();
            StartCoroutine(RestartGameIE2());
        }
        else
        {
            SceneManager.LoadScene("Game2");

        }
        IEnumerator RestartGameIE2()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("Game2");
        }
    }

    public void ReturnToMenu()
    {
        if (PlayerPrefs.GetString("music") != "No")
        {
            GetComponent<AudioSource>().Play();
            StartCoroutine(RestartGameIE());
        }
        else
        {
            SceneManager.LoadScene("Menu");

        }
        IEnumerator RestartGameIE()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("Menu");
        }
    }

    public void MusicWork()
    {
        if (PlayerPrefs.GetString("music") == "No")
        {
            GetComponent<AudioSource>().Play();
            PlayerPrefs.SetString("music", "Yes");
            GetComponent<Image>().sprite = musicOn;
        }
        else
        {
            PlayerPrefs.SetString("music", "No");
            GetComponent<Image>().sprite = musicOff;
        }
    }
}

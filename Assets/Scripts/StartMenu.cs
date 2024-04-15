using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;
using UnityEngine.SceneManagement;

public class StartMenu: MonoBehaviour
{
    public AudioSource audioStart;
    public AudioSource audioExit;

    public void OnPlayButton()
    {
        audioStart.Play();
        StartCoroutine(WaitForSound(audioStart));
        SceneManager.LoadScene("MainScene");
    }

    public void OnExitButton()
    {
        audioExit.Play();
        StartCoroutine(WaitForSound(audioStart));
        Application.Quit();
    }
    public IEnumerator WaitForSound(AudioSource Sound)
    {
        yield return new WaitUntil(() => Sound.isPlaying == false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //public GameObject loadingScreen;
    //public Slider slider;
    //public Text progressText;

    public static ChangeScene instance;
    //public int IndexOfLoadedScene;

    private void Awake()
    {
        instance = this;
    }

    public void LoadByIndex(int IndexOfLoadedScene)
    {
        SceneManager.LoadScene(IndexOfLoadedScene);

        //loadingScreen.SetActive(true);
        //StartCoroutine(loadAsynchronously());
    }

    //IEnumerator loadAsynchronously()
    //{
    //    AsyncOperation operation = SceneManager.LoadSceneAsync(level);

    //    while (operation.isDone == false)
    //    {
    //        float progress = Mathf.Clamp01(operation.progress / 0.9f);
    //        slider.value = progress;
    //        progressText.text = (progress * 100f).ToString("F0") + "%";
    //        Debug.Log(progress);

    //        if (operation.isDone)
    //        {
    //            loadingScreen.SetActive(false);
    //        }

    //        yield return null;
    //    }
    //}
}

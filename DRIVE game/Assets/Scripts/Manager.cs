using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
   public int level = 1;
   public GameObject[] closedlevel;

    void Start()
    {
        level = PlayerPrefs.GetInt("level", level);
        for (int i = 0; i < level; i++)
        {
            closedlevel[i].SetActive(false);
        }
    }
    public void OpenScene_1()
    {
        SceneManager.LoadScene("Map1");
    }
    public void OpenScene_2()
    {
        SceneManager.LoadScene("Map2");
    }
    public void OpenScene_3()
    {
        SceneManager.LoadScene("Map3");
    }
    public void OpenScene_4()
    {
        SceneManager.LoadScene("Map4");
    }
    public void OpenScene_5()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

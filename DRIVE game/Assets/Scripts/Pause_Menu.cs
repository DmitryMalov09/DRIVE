using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause_Menu : MonoBehaviour
{
    public GameObject Pause_Panel;

    public void Pause_Of()
    {
        Pause_Panel.SetActive(false);

        Time.timeScale = 1f;
    }

    public void To_Menu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            Time.timeScale = 0f;

            Pause_Panel.SetActive(true);
        }

    }
}
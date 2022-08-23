using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public bool mainMenu = true;
    public GameObject mainMenuPanel;

    public bool creditMenu = false;
    public GameObject creditMenuPanel;

    public bool InstructionMenu = false;
    public GameObject InstructionMenuPanel;

    public void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        
    }

    public void StartGame()
    {
        if (InstructionMenu == false)
        {
            mainMenuPanel.SetActive(false);
            creditMenuPanel.SetActive(false);
            InstructionMenuPanel.SetActive(true);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void CreditsOn()
    {

        if (creditMenu == false)
        {
            mainMenuPanel.SetActive(false);
            creditMenuPanel.SetActive(true);
        }
    }

    public void MainMenuOn()
    {

        if (mainMenu == false)
        {
            mainMenuPanel.SetActive(true);
            creditMenuPanel.SetActive(false);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

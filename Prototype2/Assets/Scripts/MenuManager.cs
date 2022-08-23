using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject mainMenuPanel;

    public GameObject creditMenuPanel;

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
       
            mainMenuPanel.SetActive(false);
            creditMenuPanel.SetActive(false);
            InstructionMenuPanel.SetActive(true);
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void CreditsOn()
    {

      
            mainMenuPanel.SetActive(false);
            creditMenuPanel.SetActive(true);
       
    }

    public void MainMenuOn()
    {

       
            mainMenuPanel.SetActive(true);
            creditMenuPanel.SetActive(false);
      
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

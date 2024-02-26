using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BackMainMenu : MonoBehaviour

{
    // Start is called before the first frame update

    public Button mainMenuButton;

    public GameObject mainMenu;
    public GameObject credit;
    void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        mainMenu.SetActive(true);
        credit.SetActive(false);
    }
}

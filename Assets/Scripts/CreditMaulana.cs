using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CreditMaulana : MonoBehaviour

{
    // Start is called before the first frame update

    public Button creditButton;

    public GameObject credit;
    
    public void Start()
    {
        credit.SetActive(false);
        creditButton.onClick.AddListener(CreditButton);
    }

    // Update is called once per frame

    public void CreditButton()
    {
        credit.SetActive(true);
    }
}


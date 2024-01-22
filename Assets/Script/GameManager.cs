using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private string playerName = "";
    public GameObject Button;
    public GameObject wrongText;
    public GameObject StartPannel;
    public InputField inputText;
    public GameObject SelectPannel;
    public Text PlayerName;
    public GameObject selectChar1;
    public GameObject selectChar2;
    public string playerchar = "selectChar1";
    public GameObject Char1;
    public GameObject Char2;

    public static GameManager I;

    void Awake()
    {
        I = this; 
    }
    // Star
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerchar == "selectChar1")
        {
            selectChar1.SetActive(true);
            selectChar2.SetActive(false);
        } else
        {
            selectChar1.SetActive(false);
            selectChar2.SetActive(true);
        }
    }

    public string SelectChar()
    {
         return playerchar;
    }

    public void ButtonClick()
    {
        if (playerName.Length < 2)
        {
            wrongText.SetActive(true);
        }
        else
        {
            StartPannel.SetActive(false);
            PlayerName.text = playerName;
            Debug.Log(playerName);
        }

    }

    public void TextInput(Text text)
    {
        text.text = inputText.text;
        playerName = inputText.text;
        Debug.Log(inputText.text);

    }

    public void ClickmyChar1()
    {
        playerchar = "selectChar1";
        SelectPannel.SetActive(false );
        Char1.SetActive(true);
        Char2.SetActive(false);
    }
    public void ClickmyChar2()
    {
        playerchar = "selectChar2";
        SelectPannel.SetActive(false);
        Char2.SetActive(true);
        Char1.SetActive(false);
    }

    public void ReturnSelect()
    {
        SelectPannel.SetActive(true);
    }

}

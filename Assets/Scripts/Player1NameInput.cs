using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player1NameInput : MonoBehaviour
{

    [SerializeField] private TMP_InputField nameInputField = null;
/*    [SerializeField] private Button footballButton = null;
    [SerializeField] private Button basketballButton = null;*/

    private const string Player1PrefsNameKey = "Player 1";


    // Start is called before the first frame update
    void Start()
    {
        SetUpInputField();
    }

    private void SetUpInputField()
    {
        if (!PlayerPrefs.HasKey(Player1PrefsNameKey)) { return; }

        string defaultName = PlayerPrefs.GetString(Player1PrefsNameKey);

        nameInputField.text = defaultName;

        SetPlayer1Name(defaultName);
    }

    public void SetPlayer1Name(string name1)
    {
       /* footballButton.interactable = !string.IsNullOrEmpty(name1);
        basketballButton.interactable = !string.IsNullOrEmpty(name1);*/
    }

    public void SavePlayer1Name()
    {
        string Player1Name = nameInputField.text;

        PhotonNetwork.NickName = Player1Name;

        PlayerPrefs.SetString(Player1PrefsNameKey, Player1Name);
    }

}


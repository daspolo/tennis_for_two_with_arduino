using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SettingsLobby : MonoBehaviour
{
    [SerializeField]
    TMP_InputField ballSpeed;

    private void Start()
    {
        if (PlayerPrefs.GetFloat("ballSpeed") > 0)
        {
            ballSpeed.text = PlayerPrefs.GetFloat("ballSpeed").ToString();
        }
    }
    public void save()
    {
        PlayerPrefs.SetFloat("ballSpeed",  float.Parse(ballSpeed.text));
    }
}

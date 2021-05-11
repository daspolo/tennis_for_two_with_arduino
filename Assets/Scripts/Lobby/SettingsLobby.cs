using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SettingsLobby : MonoBehaviour
{
    [SerializeField]
    TMP_InputField ballSpeed;
    [SerializeField]
    TMP_InputField delayShoot;

    private void Start()
    {
        if (PlayerPrefs.GetFloat("ballSpeed") > 0)
        {
            ballSpeed.text = PlayerPrefs.GetFloat("ballSpeed").ToString();
            delayShoot.text = PlayerPrefs.GetFloat("delayShoot").ToString();
        }
    }
    public void save()
    {
        PlayerPrefs.SetFloat("ballSpeed",  float.Parse(ballSpeed.text));
        PlayerPrefs.SetFloat("delayShoot", float.Parse(delayShoot.text));
    }
}

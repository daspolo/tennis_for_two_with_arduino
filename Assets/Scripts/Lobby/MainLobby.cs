using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLobby : MonoBehaviour
{


    [SerializeField]
    TMP_InputField dispositivo;

    void Start()
    {
        if(PlayerPrefs.GetString("dispositivo")!=null)
            dispositivo.text = PlayerPrefs.GetString("dispositivo");
          
    }

    public void play()
    {
        if(string.IsNullOrEmpty(dispositivo.text))
        {
            dispositivo.placeholder.color = Color.red;
            return;
        }

        PlayerPrefs.SetString("dispositivo", dispositivo.text);
        SceneManager.LoadScene(1);
        
    }

}

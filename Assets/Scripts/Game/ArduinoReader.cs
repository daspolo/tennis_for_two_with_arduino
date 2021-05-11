using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class ArduinoReader : MonoBehaviour
{
    // Cambia a seconda della porta del computer collegata a quella di arduino
    private string deviceFile;

    // La porta è stata fissata da arduino
    private SerialPort sp;


    [SerializeField]
    ballManager ball;

    void Start()
    {
        deviceFile = PlayerPrefs.GetString("dispositivo");
        sp = new SerialPort(deviceFile, 9600);      
        sp.ReadTimeout = 100;
        sp.Open();
    }

    void Update()
    {

        if (sp.IsOpen)
        {
            // CONTROLLO SE QUALCHE PULSANTE VIENE CLICCATO
            string s = readSerialPort();
            if (s != null)
            {
                string[] inf = s.Split(' ');

                if (inf[0].Equals("LEFT"))
                {
                    if(ball.transform.position.x < 0 && !ball.alreadShoot(true))
                    {
						ball.tira(true);
                        float angolo = float.Parse(inf[1]);
                        angolo = angolo * 30 / 1023;
                        ball.addForceWithAngle(angolo);
                    }

                }
                else if (inf[0].Equals("RIGHT"))
                {
                    if(ball.transform.position.x > 0 && !ball.alreadShoot(false))
                    {
						ball.tira(false);
                        float angolo = float.Parse(inf[1]);
                        angolo = 180 - (angolo * 30 / 1023);
                        ball.addForceWithAngle(angolo);
                    }
                    
                }
            }


        }
    }

    public string readSerialPort(int timeout = 50)
    {
        string message;
        sp.ReadTimeout = timeout;
        try
        {
            message = sp.ReadLine();
            return message;
        }
        catch (System.TimeoutException)
        {
            return null;
        }
    }
}

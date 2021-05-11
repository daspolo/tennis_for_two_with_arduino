using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour
{
	private bool alreadyShootPlayer_1 = false;
	private bool alreadyShootPlayer_2 = false;
	
    Rigidbody rb;

    [SerializeField]
    GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {          
        if(transform.position.y < -4)
            gameManager.respawn();
                 
		if(alreadyShootPlayer_1 && transform.position.x > 0)
			alreadyShootPlayer_1 = false;
		
		if(alreadyShootPlayer_2 && transform.position.x < 0)
			alreadyShootPlayer_2 = false;
    }
    
    public void addForceWithAngle(float angle, float force = 3.9f)
    {

        if (PlayerPrefs.GetFloat("ballSpeed") > 0)      
            force = PlayerPrefs.GetFloat("ballSpeed");
        
        rb.angularVelocity = Vector3.zero;
        rb.velocity = Vector3.zero;

        // TRANSFORMO IN RADIANTI
        angle *= Mathf.Deg2Rad;

        float y = Mathf.Sin(angle) * force;

        float x = Mathf.Cos(angle) * force;

        Vector3 forceApplied = new Vector3(x, y, 0);

        rb.AddForce(forceApplied, ForceMode.Impulse);
    }
	
	public void tira(bool isPlayer_1)
	{
		if (isPlayer_1)
			alreadyShootPlayer_1 = true;
		else
			alreadyShootPlayer_2 = true;
	}
	
	public bool alreadShoot(bool isPlayer_1) {
        	return isPlayer_1 ? alreadyShootPlayer_1 : alreadyShootPlayer_2;
    	}

}

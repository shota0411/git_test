using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver: MonoBehaviour 
{

	[SerializeField] private Text gameoverText;
	[SerializeField] private GameObject ball;
	void Start () 
	{		
		
	}

	void Update () 
	{
		if(ball.transform.position.y < 0.4){
			gameoverText.text = "GameOver!!";
		}
	}


}

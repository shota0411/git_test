using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearUI : MonoBehaviour 
{

	[SerializeField] private Text clearText;

	void Start () 
	{		
	}

	void Update () 
	{
			
	}

	void OnTriggerEnter ()
	{
		clearText.text = "CLEAR!!";
	}
}

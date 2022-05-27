// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetection : MonoBehaviour
{

	#region Variables
	[SerializeField] float reloadDelay = 0.75f;
	#endregion

	#region Unity Methods

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			Debug.Log("Ouch!!");
			Invoke("ReloadScene", reloadDelay);
		}
	}

	void ReloadScene()
	{
		SceneManager.LoadScene(0);
	}

	#endregion

}

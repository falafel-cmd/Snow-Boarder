// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{

	#region Variables
	[SerializeField] float levelChangeDelay = 1.25f;
	[SerializeField] ParticleSystem finishFX;
	[SerializeField] AudioSource finishSound;
	#endregion

	#region Unity Methods

	void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			finishFX.Play();
			finishSound.Play();
			Debug.Log("Player has reached the finish line");
			Invoke("ReloadScene", levelChangeDelay);
		}
	}

	void ReloadScene()
	{
		SceneManager.LoadScene(0);
	}
	#endregion

}

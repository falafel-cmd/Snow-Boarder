// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{

	#region Variables

	#endregion

	#region Unity Methods

	void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			Debug.Log("Player has reached the finish line");
		}
	}
	#endregion

}

// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish : MonoBehaviour
{

	#region Variables

	#endregion

	#region Unity Methods

	void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			Debug.Log("Player has reached the finihs line");
		}
	}
	#endregion

}

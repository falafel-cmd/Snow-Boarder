// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTrail : MonoBehaviour
{

	#region Variables
	[SerializeField] ParticleSystem trailFX;
	#endregion

	#region Unity Methods

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			trailFX.Play();
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			trailFX.Pause();
		}
	}
	#endregion

}

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

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ground")
		{
			trailFX.Play();
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ground")
		{
			trailFX.Pause();
		}
	}

	#endregion

}

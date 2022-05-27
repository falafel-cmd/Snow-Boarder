// Copyright (c) Fathi Mokhtar

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	#region Variables

	Rigidbody2D rb2d;
	[SerializeField] float playerTorque = 1.5f;
	float playerSpeed = 10f;
	float playerBoost = 20f;
	SurfaceEffector2D surfaceEffector2D;

	#endregion

	#region Unity Methods

	void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
		surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
		RotatePlayer();
		PlayerBoost();
    }

	private void PlayerBoost()
	{
		if (Input.GetKey(KeyCode.B))
		{
			surfaceEffector2D.forceScale = playerBoost;
		}
		else
		{
			surfaceEffector2D.forceScale = playerSpeed;
		}
	}

	void RotatePlayer()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rb2d.AddTorque(playerTorque);
		}

		else if (Input.GetKey(KeyCode.RightArrow))
		{
			rb2d.AddTorque(-(playerTorque));
		}
	}

	#endregion

}

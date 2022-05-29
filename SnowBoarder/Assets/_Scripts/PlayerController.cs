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
	[SerializeField] float playerSpeed = 10f;
	[SerializeField] float playerBoost = 50f;
	SurfaceEffector2D surfaceEffector2D;
	bool canMove = true;

	#endregion

	#region Unity Methods

	void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
		surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
		if (canMove)
		{
			RotatePlayer();
			PlayerBoost();
		}
    }

	private void PlayerBoost()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			surfaceEffector2D.speed = playerBoost;
		}
		else
		{
			surfaceEffector2D.speed = playerSpeed;
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

	public void DisableControls()
	{
		canMove = false;
	}

	#endregion

}

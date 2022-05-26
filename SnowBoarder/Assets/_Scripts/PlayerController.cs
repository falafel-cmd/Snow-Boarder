// Copyright (c) Fathi Mokhtar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	#region Variables

	Rigidbody2D rb2d;
	[SerializeField] float playerTorque = 1.5f;

	#endregion

	#region Unity Methods

	void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			rb2d.AddTorque(playerTorque);
		}

		if(Input.GetKey(KeyCode.RightArrow))
		{
			rb2d.AddTorque(-(playerTorque));
		}
    }

	#endregion

}

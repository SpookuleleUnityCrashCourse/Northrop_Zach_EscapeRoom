using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	public Player player;
	public ControlData controlData;

	//All we want to do in start is hide the cursor.
	void Start()
	{
		HideCursor();
	}

	//In update, so every frame...
	//Update the movement input and the turning input
	void Update()
	{
		MovementInput();
		TurningInput();
	}

	void MovementInput()
	{
		float x = Input.GetAxisRaw(controlData.controlHoriz); //Get x axis input, or A/D (changes to W/S with fucky controls)
		float y = Input.GetAxisRaw(controlData.controlVert); //Get y axis input, or W/S (changes to A/D with fucky controls)
		player.movementDirection = new Vector2(x, y); //Set the player's movement direction based on input
		player.running = Input.GetKey(KeyCode.LeftShift); //Set if the player is running or not based on holding left shift
	}

	void TurningInput()
	{
		float mouseX = Input.GetAxisRaw(controlData.lookX); //Get x mouse input (changes to y input with fucky controls)
		float mouseY = Input.GetAxisRaw(controlData.lookY); //Get y mouse input (changes to x input with fucky controls)
		player.amountToRotateX = mouseX; //set the appropriate amounts to rotate
		player.amountToRotateY = -mouseY;
	}
	
	void HideCursor()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {	
	
	public void Update () 
	{
		var gamepad = Gamepad.current;
		var keyboard = Keyboard.current;


		if (gamepad.selectButton.isPressed | keyboard.rKey.isPressed)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			Debug.Log("Restart key pressed.");
		}
	}
}

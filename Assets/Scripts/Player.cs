using UnityEngine;

// RequireComponent will be automatically added ! :D sweet
[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{

	public float MoveSpeed = (float) 7.5;
	private PlayerController _controller;
	
	void Start ()
	{
		// attached to same object as this script
		_controller = GetComponent<PlayerController>();
	}
	
	void Update () {
		Vector3 moveInput 		= new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		Vector3 moveVelocity 	= moveInput.normalized * MoveSpeed;
		
		_controller.Move(moveVelocity);
	}
}

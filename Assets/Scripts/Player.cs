using UnityEngine;

// RequireComponent will be automatically added ! :D sweet
[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{

	public 	float 				MoveSpeed = (float) 7.5;
	private Camera 				_viewCamera;
	private PlayerController 	_controller;

	private void Start ()
	{
		// attached to same object as this script
		_controller = GetComponent<PlayerController>();
		
		_viewCamera = Camera.main;
	}

	private void Update () {
		Vector3 moveInput 		= new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Vector3 moveVelocity 	= moveInput.normalized * MoveSpeed;
		
		_controller.Move(moveVelocity);

		Ray ray = _viewCamera.ScreenPointToRay(Input.mousePosition);
		Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
		float rayDistance;

		if (groundPlane.Raycast(ray, out rayDistance))
		{
			Vector3 point = ray.GetPoint(rayDistance);
			//Debug.DrawLine(ray.origin, point, Color.red);
			_controller.LookAt(point);
		}
	}
}

using UnityEngine;

// RequireComponent will be automatically added ! :D sweet
[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class Player : LivingEntity
{

	public 	float 				MoveSpeed = (float) 7.5;
	private Camera 				_viewCamera;
	private PlayerController 	_controller;
	private GunController 		_gunController;

	protected override void Start ()
	{
		base.Start();
		
		// attached to same object as this script
		_controller 	= GetComponent<PlayerController>();
		_gunController 	= GetComponent<GunController>();
		_viewCamera 	= Camera.main;
	}

	private void Update () {
		
		// Movement input
		Vector3 moveInput 		= new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Vector3 moveVelocity 	= moveInput.normalized * MoveSpeed;
		
		_controller.Move(moveVelocity);

		
		// Look input
		Ray ray = _viewCamera.ScreenPointToRay(Input.mousePosition);
		Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
		float rayDistance;

		if (groundPlane.Raycast(ray, out rayDistance))
		{
			Vector3 point = ray.GetPoint(rayDistance);
			//Debug.DrawLine(ray.origin, point, Color.red);
			_controller.LookAt(point);
		}
		
		// Weapon input
		if (Input.GetMouseButton(0))
		{
			_gunController.Shoot();
		}
	}
}

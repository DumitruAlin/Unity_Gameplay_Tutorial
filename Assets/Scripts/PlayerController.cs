using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
	private Vector3 	_velocity;
	private Rigidbody 	_myRigidBody;

	private void Start ()
	{
		_myRigidBody = GetComponent<Rigidbody>();
	}

	public void Move(Vector3 inVelocity)
	{
		_velocity = inVelocity;
	}

	public void LookAt(Vector3 lookPoint)
	{
		var heightCorrectedPoint = new Vector3(lookPoint.x, transform.position.y, lookPoint.z);
		transform.LookAt(heightCorrectedPoint);
	}
	
	// move rigid body only in the fixed update, at small regular increments (for physics ?)
	private void FixedUpdate()
	{
		_myRigidBody.MovePosition(_myRigidBody.position + _velocity * Time.fixedDeltaTime);
	}
}

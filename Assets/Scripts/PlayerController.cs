using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
	Vector3 _velocity;
	Rigidbody _myRigidBody;
	
	void Start ()
	{
		_myRigidBody = GetComponent<Rigidbody>();
	}

	public void Move(Vector3 inVelocity)
	{
		_velocity = inVelocity;
	}
	
	// move rigid body only in the fixed update, at small regular increments (physics ? ? ? )
	private void FixedUpdate()
	{
		_myRigidBody.MovePosition(_myRigidBody.position + _velocity * Time.fixedDeltaTime);
	}
}

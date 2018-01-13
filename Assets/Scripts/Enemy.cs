using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : LivingEntity
{
	private NavMeshAgent 	pathFinder;
	private Transform 		target;
	
	protected override void Start () {
		base.Start();
		pathFinder 	= GetComponent<NavMeshAgent>();
		target 		= GameObject.FindGameObjectWithTag("Player").transform;
		StartCoroutine(UpdatePath());
	}

	//private void Update () {
	//}

	
	// reduce path calculations, form each frame to a given interval (.25 seconds) 
	private IEnumerator UpdatePath() {
		const float refreshRate = .25f;

		while (target != null)
		{
			Vector3 targetPosition = new Vector3(target.position.x, 0, target.position.z);
			
			if (!dead)
			{
				pathFinder.SetDestination(targetPosition);
			}

			yield return new WaitForSeconds(refreshRate);
		}
	}
}

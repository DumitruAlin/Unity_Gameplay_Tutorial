using UnityEngine;

public class TickEr : MonoBehaviour {

	// Use this for initialization
	// ReSharper disable once Unity.RedundantEventFunction
	private void Start () {
		
	}

	private int _x;
	// Update is called once per frame
	private void Update ()
	{
		System.Console.Write("Tick-ing: ");
		System.Console.WriteLine(_x++);
	}
}
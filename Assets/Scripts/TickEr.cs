using UnityEngine;

public class TickEr : MonoBehaviour {

	// Use this for initialization
	// ReSharper disable once Unity.RedundantEventFunction
	private void Start ()
	{
		Debug.Log("<color=blue>Object Initialised: </color>" + this);
	}

	private int _x;
	// Update is called once per frame
	private void Update ()
	{
		Debug.Log("<color=red>x: </color>" + _x++);		
	}
}
using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	private GameControllerScript _gcScript;
	public  int flagValue = 0;

	// Use this for initialization
	void Start () {
		_gcScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
	}

	void OnMouseDown() {
		_gcScript.AddMove(flagValue);
	}
}

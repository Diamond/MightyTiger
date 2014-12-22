using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour {

//	Left   = 1
//	Right  = 2
//	Punch  = 4
//	Kick   = 8
//	Rotate = 16
//	Guard  = 32
//	
//	LEFT KICK    = 1 | 8  = 9 
//	RIGHT KICK   = 2 | 8  = 10
//	LEFT PUNCH   = 1 | 4  = 5
//	RIGHT PUNCH  = 2 | 4  = 6
//	ROTATE LEFT  = 1 | 16 = 17
//	ROTATE RIGHT = 2 | 16 = 18
//	GUARD                 = 32
//	
//	PUNCHES
//	--------
//	JAB        = 1 | 4      = 5
//	CROSS      = 2 | 4      = 6
//	LEFT HOOK  = 1 | 4 | 16 = 21
//	RIGHT HOOK = 2 | 4 | 16 = 22
//	
//	KICKS
//	-----
//	FRONT PUSH  = 1 | 8      = 9
//	REAR PUSH   = 2 | 8      = 10
//	LEFT ROUND  = 1 | 8 | 16 = 25 
//	RIGHT ROUND = 2 | 8 | 16 = 26
//	LEFT KNEE   = 1 | 8 | 32 = 41
//	RIGHT KNEE  = 2 | 8 | 32 = 42

	public int  moveFlag;
	public Text moveDisplay;

	// Use this for initialization
	void Start () {
		moveFlag = 0;

		Debug.Log ((1 | 4 | 17).ToString());
	}
	
	// Update is called once per frame
	void Update () {
		switch(moveFlag) {
		case 42:
			SetDisplayText("Right Knee");
			break;
		case 41:
			SetDisplayText("Left Knee");
			break;
		case 26:
			SetDisplayText("Right Round Kick");
			break;
		case 25:
			SetDisplayText("Left Round Kick");
			break;
		case 10:
			SetDisplayText("Back Push");
			break;
		case 9:
			SetDisplayText("Front Push");
			break;
		case 22:
			SetDisplayText("Right Hook");
			break;
		case 21:
			SetDisplayText ("Left Hook");
			break;
		case 6:
			SetDisplayText ("Cross");
			break;
		case 5:
			SetDisplayText ("Jab");
			break;
		case 0:
		default:
			SetDisplayText ("Idle");
			break;
		}
	}

	public void AddMove(int flag) {
		if (flag == -1) {
			moveFlag = 0;
		} else {
			Debug.Log ("OR'ing " + moveFlag.ToString() + " with " + flag.ToString());
			moveFlag = moveFlag | flag;
		}
	}

	void SetDisplayText(string text) {
		moveDisplay.text = "Current Move: " + text + "\nMove Flag: " + moveFlag.ToString();
	}
}

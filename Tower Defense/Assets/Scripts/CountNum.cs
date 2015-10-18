using UnityEngine;
using System.Collections;

public class CountNum : MonoBehaviour {

	static int num = 0;

	// Use this for initialization
	static public void numberIncrease (){
		num++;
	}

	static public void numberDecrease (){
		num--;
	}

	static public bool noAlive(){
		if (num == 0) {
			return true;
		} else {
			return false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

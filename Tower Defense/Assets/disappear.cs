using UnityEngine;
using System.Collections;

public class disappear : MonoBehaviour {

	// Use this for initialization
	void wake () {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
	
}

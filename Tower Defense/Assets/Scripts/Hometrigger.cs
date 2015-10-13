using UnityEngine;
using System.Collections;

public class Hometrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D co)
    {

        if (co.GetComponent<Monster>())
        {
            iTween.Stop(co.gameObject);
            Destroy(co.gameObject);
        }
    }
}

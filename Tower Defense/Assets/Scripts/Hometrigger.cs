using UnityEngine;
using System.Collections;

public class Hometrigger : MonoBehaviour {

	public int homeHealth = 5;
	public Canvas loseCanvas;

	// Use this for initialization
	void Start () {
		
		loseCanvas = loseCanvas.GetComponent<Canvas> ();
		
		loseCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D co)
    {

        if (co.GetComponent<Monster>())
        {
			if (homeHealth > 0) {
				homeHealth--;
			}
			else {
				loseCanvas.enabled = true;
				iTween.Stop();
			}
            iTween.Stop(co.gameObject);
            Destroy(co.gameObject);
        }
    }
}

using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    float health = 5f;
    // Use this for initialization
    void Start () {
	
	}
	
    public void decrease()
    {
        if (health > 1)
        {
            health--;
        }
        else
        {
            Destroy(transform.parent.gameObject);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}

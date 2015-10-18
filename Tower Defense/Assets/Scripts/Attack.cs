using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

    public GameObject Bullet_prefab;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.GetComponent<Monster>())
        {
            GameObject g = (GameObject)Instantiate(Bullet_prefab, transform.position, Quaternion.identity);
            g.GetComponent<Bullet>().target = co.transform;

        }
    }

    void Start () {
        //Debug.Log("test begin");
	}
	
	// Update is called once per frame
	void Update () {
        
    }


    
}

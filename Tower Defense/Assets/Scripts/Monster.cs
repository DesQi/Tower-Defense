using UnityEngine;
using System.Collections;


public class Monster : MonoBehaviour {

    public GameObject moneyObject2;
    float health = 5f;
    // Use this for initialization
    void Start ()
    {
        moneyObject2 = GameObject.Find("TotalMoney");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void decrease()
    {
        if (health > 1)
        {
            health--;
        }
        else
        {
            
            iTween.Stop(gameObject);
            Destroy(gameObject);
            moneyObject2.GetComponent<PlayerMoney>().addMoney(200);
        }
    }

    public void Destroyathome(GameObject x)
    {
            
    }
}

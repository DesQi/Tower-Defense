using UnityEngine;
using System.Collections;

public class towertrigger : MonoBehaviour {

	// Use this for initialization
	
    public  GameObject tower_1;
    public GameObject tower_2;
    public GameObject tower_3;
    public GameObject tower_4;
    Vector3 tower_1_position;
    Vector3 tower_2_position;
    Vector3 tower_3_position;
    Vector3 tower_4_position;
    GameObject fake_1;
    GameObject fake_2;
    GameObject fake_3;
    GameObject fake_4;
    Vector3 position;
    
    bool getbutton =false;
    // Update is called once per frame
    void Update () {

        
        if (getbutton)
        {
            if(Input.GetKey("q"))
            {
                Instantiate(tower_1, gameObject.transform.position, Quaternion.identity);
                Destroy(fake_1);
                Destroy(fake_2);
                Destroy(fake_3);
                Destroy(fake_4);
                getbutton = false;
            }
            else if (Input.GetKey("w"))
            {
                Instantiate(tower_2, gameObject.transform.position, Quaternion.identity);
                Destroy(fake_1);
                Destroy(fake_2);
                Destroy(fake_3);
                Destroy(fake_4);
                getbutton = false;
            }
            else if (Input.GetKey("e"))
            {
                Instantiate(tower_3, gameObject.transform.position, Quaternion.identity);
                Destroy(fake_1);
                Destroy(fake_2);
                Destroy(fake_3);
                Destroy(fake_4);
                getbutton = false;
            }
            else if (Input.GetKey("r"))
            {
                Instantiate(tower_4, gameObject.transform.position, Quaternion.identity);
                Destroy(fake_1);
                Destroy(fake_2);
                Destroy(fake_3);
                Destroy(fake_4);
                getbutton = false;
            }
            else { }
               
            }


        }
    void OnMouseDown()
    {
        
            fake_1 = (GameObject)Instantiate(tower_1, new Vector3(10, -12, 0), Quaternion.identity);
            fake_2 = (GameObject)Instantiate(tower_2, new Vector3(4, -12, 0), Quaternion.identity);
            fake_3 = (GameObject)Instantiate(tower_3, new Vector3(-2, -12, 0), Quaternion.identity);
            fake_4 = (GameObject)Instantiate(tower_4, new Vector3(-8, -12, 0), Quaternion.identity);
            getbutton = true;
        
    }
}

    


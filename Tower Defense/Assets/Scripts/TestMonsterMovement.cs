using UnityEngine;
using System.Collections;

public class TestMonsterMovement : MonoBehaviour {

    public GameObject Monster1;
    public Vector3 OriginalPlace;
    GameObject[] newMonster = new GameObject[5];
    void Start()
    {
        
        for (int i = 0; i < 5; i++)
        {
            newMonster[i] = (GameObject)Instantiate(Monster1, OriginalPlace, Quaternion.identity) as GameObject;

            iTween.MoveTo(newMonster[i], iTween.Hash("path", iTweenPath.GetPath("MonsterPath"), "speed", 10, "delay", i, "easetype", iTween.EaseType.linear));

           // yield return new WaitForSeconds(5f);

        }

    }

	// Update is called once per frame
	void Update () {
	    for(int i = 0;i < 5; i++)
        {
            Destroyathome(newMonster[i]);

        }
	}

    public Vector3 homePosition;
    void Destroyathome(GameObject x)
    {
        if (x.transform.position.x <= homePosition.x + 1 &&
            x.transform.position.x >= homePosition.x - 1 &&
            x.transform.position.y <= homePosition.y + 1 &&
            x.transform.position.y >= homePosition.y - 1)
        {
            x.GetComponent<Renderer>().enabled = false;
        }

    }
}

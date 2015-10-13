using UnityEngine;
using System.Collections;

public class TestMonsterMovement : MonoBehaviour {

    //public GameObject Monsters[] = new GameObject;
    public GameObject Monster1;
    public Vector3 OriginalPlace;
    GameObject[] newMonster = new GameObject[10];

    void Start()
    {
        
        for (int i = 0; i < 10; i++)
        {
            newMonster[i] = (GameObject)Instantiate(Monster1, OriginalPlace, Quaternion.identity) as GameObject;
            
            iTween.MoveTo(newMonster[i], iTween.Hash("path", iTweenPath.GetPath("MonsterPath"), "speed", 10, "delay", i, "easetype", iTween.EaseType.linear));
            
           // yield return new WaitForSeconds(5f);

        }

    }

	
}



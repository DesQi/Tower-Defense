using UnityEngine;
using System.Collections;

public class TestMonsterMovement : MonoBehaviour {

	//public GameObject Monsters[] = new GameObject;
	public Canvas winCanvas;
    public GameObject Monster1;
    public Vector3 OriginalPlace;
    GameObject[] newMonster = new GameObject[10];
	//Monster[] testMonster = new Monser1[10];
	bool noWaves = false;

    void Start()
	{
		winCanvas = winCanvas.GetComponent<Canvas> ();
		
		winCanvas.enabled = false;
        
        for (int i = 0; i < 10; i++)
        {
            newMonster[i] = (GameObject)Instantiate(Monster1, OriginalPlace, Quaternion.identity) as GameObject;
            
            iTween.MoveTo(newMonster[i], iTween.Hash("path", iTweenPath.GetPath("MonsterPath"), "speed", 10, "delay", i, "easetype", iTween.EaseType.linear));
            
           // yield return new WaitForSeconds(5f);

        }

		noWaves = true;

    }

	void Update(){
		Debug.Log (Monster.number);
		if (Monster.number == 0 && noWaves) {
			winCanvas.enabled = true;
		}
	}
}



using UnityEngine;
using System.Collections;

public class Map2 : MonoBehaviour
{

    //public GameObject Monsters[] = new GameObject;
    public Canvas winCanvas;
    public GameObject Monster1;
    public GameObject Monster2;
    public Vector3 OriginalPlace;
    GameObject[] newMonster = new GameObject[10];
    GameObject[] newMonster2 = new GameObject[10];
    //Monster[] testMonster = new Monser1[10];
    bool noWaves = false;
    int monsterNum = 0;

    void Start()
    {
        winCanvas = winCanvas.GetComponent<Canvas>();

        winCanvas.enabled = false;

        for (int i = 0; i < 10; i++)
        {
            newMonster[i] = (GameObject)Instantiate(Monster1, OriginalPlace, Quaternion.identity) as GameObject;

            iTween.MoveTo(newMonster[i], iTween.Hash("path", iTweenPath.GetPath("MonsterPath"), "speed", 10, "delay", i, "easetype", iTween.EaseType.linear));

            // yield return new WaitForSeconds(5f);
            monsterNum++;

        }



    }

    void Update()
    {
        Debug.Log(monsterNum);

        if (monsterNum == 0 && !noWaves)
        {
            //winCanvas.enabled = true;
            for (int i = 0; i < 10; i++)
            {
                newMonster2[i] = (GameObject)Instantiate(Monster2, OriginalPlace, Quaternion.identity) as GameObject;

                iTween.MoveTo(newMonster2[i], iTween.Hash("path", iTweenPath.GetPath("MonsterPath"), "speed", 15, "delay", i, "easetype", iTween.EaseType.linear));

                // yield return new WaitForSeconds(5f);
                monsterNum++;
            }
            noWaves = true;
        }

        if (monsterNum == 0 && noWaves)
        {
            winCanvas.enabled = true;
        }
    }

    public void decreaseNum()
    {
        monsterNum--;
    }

    public void SecondMap()
    {
        Application.LoadLevel(2);
    }
}



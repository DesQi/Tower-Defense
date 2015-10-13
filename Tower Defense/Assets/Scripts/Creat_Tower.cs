using UnityEngine;
using System.Collections;

public class Creat_Tower : MonoBehaviour {
    public GameObject tower_monkey;
    public GameObject tower_lion;
    public GameObject tower_elephant;
    public GameObject tower_penguin;
    public Canvas TowerMemu;
    public GameObject grass;
    public Vector3 position_now;
    //    public Ray ray;
    
    bool monkeyflag = false;
    bool lionflag = false;
    bool elephantflag = false;
    bool penguinflag = false;
    bool emptyflag = true;
    // Use this for initialization
    void Start () {
        TowerMemu = TowerMemu.GetComponent<Canvas>();

        TowerMemu.enabled = false;
    }

    void Update()
    {
        if (!emptyflag)
            return;
        else if (monkeyflag)
        {
            //            if (Physics.Raycast(ray))
            //            {
            //                Instantiate(tower_monkey, transform.position, transform.rotation);
            //            }
            Instantiate(tower_monkey, position_now, Quaternion.identity);
            emptyflag = false;
            monkeyflag = false;
            Debug.Log(position_now.x);
            Debug.Log(position_now.y);

        }
        else if (lionflag)
        {
            Instantiate(tower_lion, position_now, Quaternion.identity);
            emptyflag = false;
            lionflag = false;
        }
        else if (elephantflag)
        {
            Instantiate(tower_elephant, position_now, Quaternion.identity);
            emptyflag = false;
            elephantflag = false;
        }
        else if (penguinflag)
        {
            Instantiate(tower_penguin, position_now, Quaternion.identity);
            emptyflag = false;
            penguinflag = false;
        }
    }

    void OnMouseDown()
    {
        
        TowerMemu.enabled = true;
        //        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        position_now = Input.mousePosition;
    }

    public void MonkeyPress()
    {
        monkeyflag = true;
        TowerMemu.enabled = false;
    }

    public void LionPress()
    {
        lionflag = true;
        TowerMemu.enabled = false;
    }

    public void ElephantPress()
    {
        elephantflag = true;
        TowerMemu.enabled = false;
    }

    public void PenguinPress()
    {
        penguinflag = true;
        TowerMemu.enabled = false;
    }

}

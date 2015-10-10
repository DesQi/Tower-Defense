using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TowerButton : MonoBehaviour
{

    public Canvas TowerMenu;
    //public Button startText;
    /*
    public Button Monkey;
    public Button Lion;
    public Button Elephant;
    public Button Penguin;
    */

    public GameObject Monkey;
    public Vector3 GrassPosition;
    GameObject[] newMonkey = new GameObject[5];



    // Use this for initialization
    void Start()
    {
        TowerMenu = TowerMenu.GetComponent<Canvas>();
        //startText = startText.GetComponent<Button>();
        /*
        Monkey = Monkey.GetComponent<Button>();
        Lion = Lion.GetComponent<Button>();
        Elephant = Elephant.GetComponent<Button>();
        Penguin = Penguin.GetComponent<Button>();
        */
        TowerMenu.enabled = false;
    }

    public void GrassPress()
    {
        TowerMenu.enabled = true;
        /*
        Monkey.enabled = true;
        Lion.enabled = true;
        Elephant.enabled = true;
        Penguin.enabled = true;
        */
    }


    public void CancelPress()
    {
        TowerMenu.enabled = false;
        /*
        Monkey.enabled = false;
        Lion.enabled = false;
        Elephant.enabled = false;
        Penguin.enabled = false;
        */
    }

    public void MonkeyPress()
    {
        newMonkey[1] = (GameObject)Instantiate(Monkey, GrassPosition, Quaternion.identity) as GameObject;
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // Do right-click stuff here
            TowerMenu.enabled = true;
        }
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // Do right-click stuff here
            TowerMenu.enabled = true;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

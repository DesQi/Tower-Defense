using UnityEngine;
using System.Collections;

public class MonkeyTower : MonoBehaviour {

    public GameObject monkey;
    public bool make_monkey;

    void start()
    {
        monkey = (GameObject)Instantiate(monkey, new Vector3(10, -12, 0), Quaternion.identity);

    }

    void OnMouseDown()
    {

        make_monkey = true;
        Destroy(monkey);

    }

}


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour {

    public int money;
    public Text moneyText;

	// Use this for initialization
	void Start () {
        money = 500;
        moneyText.text = "Money: " + money.ToString();
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
        moneyText.text = "Money: " + money.ToString();
    }

    public void substractMoney(int moneyToSubstract)
    {
        if (money - moneyToSubstract < 0)
        {
            Debug.Log("You don't have enough money");
        }
        else
        {
            money -= moneyToSubstract;
            moneyText.text = "Money: " + money.ToString();
        }
    }

    public bool getMoney()
    {
        return (money > 0);
    }
}

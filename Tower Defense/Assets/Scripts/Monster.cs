using UnityEngine;
using System.Collections;


public class Monster : MonoBehaviour {

    public GameObject moneyObject2;
    public GameObject testMonsterObject;
    int health = 0;
	int money_add = 0;
	public static int number = -1;

	public Monster(){
		number++;
	}
	
	void Start ()
	{
		moneyObject2 = GameObject.Find("TotalMoney");
        testMonsterObject = GameObject.Find("TestMonster");

    }
	
	public void changePara(int healthIn,int moneyAdd){
		health = healthIn;
		money_add = moneyAdd;
	}

    public void decrease(int damage)
    {
        if ((health - damage) > 0)
        {
            health -= damage;
        }
        else
        {
			number--;
            iTween.Stop(gameObject);
            Destroy(gameObject);
            moneyObject2.GetComponent<PlayerMoney>().addMoney(money_add);
            testMonsterObject.GetComponent<TestMonsterMovement>().decreaseNum();
		}
	
    }


}

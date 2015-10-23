using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    protected float speed;
    protected int damage;

    public Bullet()
    {
        speed = 0;
        damage = 0;
    }


    public Transform target;
	// Use this for initialization
	void FixedUpdate ()
    {
	    if (target)
        {
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;
        }
        else
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D co)
    {
        Monster monster = co.GetComponent<Monster>();
        //Debug.Log(damage);
        //Debug.Log(speed);
        if (monster)
        {
            monster.decrease(damage);
            Destroy(gameObject);
        }
    }
}

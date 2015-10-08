using UnityEngine;
using System.Collections;

public class ReachHome : MonoBehaviour {




    public Vector3 homePosition;
    void Destroyathome()
    {
        if (gameObject.transform.position.x <= homePosition.x + 1 &&
            gameObject.transform.position.x >= homePosition.x - 1 &&
            gameObject.transform.position.y <= homePosition.y + 1 &&
            gameObject.transform.position.y >= homePosition.y - 1)
        {
            Destroy(gameObject);
        }

    }

    void update()
    {

        Destroyathome();

    }



}

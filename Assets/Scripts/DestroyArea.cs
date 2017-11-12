using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArea : MonoBehaviour {

    void OnTriggerExit2D(Collider2D c)
    {
        if (c.gameObject.ToString().Substring(0, 11) == "EnemyBullet")
        {
        }
        else
        {
            bool test = true;
            bool testa = test;
        }

        Destroy(c.gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

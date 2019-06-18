using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : Roadcreat {
    /*bool isOnTriggerEnter;
    // Use this for initialization*/
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnTriggerEnter(Collider collider)
    {
        print("发生了碰撞");
        //Destroy(Road[temporaryRd]);
        //Prop.transform.position = new Vector3(Road[temporaryRd].transform.localPosition.x, 0, Road[temporaryRd].transform.localPosition.z + 30);
    }
}

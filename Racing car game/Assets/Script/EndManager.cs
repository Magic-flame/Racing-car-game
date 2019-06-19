using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        GameManager.instance.CreateRoad();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSection : MonoBehaviour {
    public bool isMove=false;
    float time = 0.5f;
    public void OnTriggerExit(Collider other)
    {
        if(other.tag=="Player")
            this.gameObject.AddComponent<Rigidbody>();
        //isMove = true;
        
    }
    private void Update()
    {
        if (!isMove)
            return;
        if (time > 0)
        {
            time -= Time.deltaTime;

        }
        if (time <= 0)
        {
            this.gameObject.AddComponent<Rigidbody>();
            isMove = false;
        }
    }

}

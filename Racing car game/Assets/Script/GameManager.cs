using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager> {

    GameObject RCC;
    public GameObject nowRoad;
    public Vector3 point = Vector3.zero;
	public void Init()
    {
        CreateRoad();
        RCC = Instantiate(Resources.Load<GameObject>("RCC"), Vector3.zero+new Vector3(0,10,-30), Quaternion.identity, RuntimeData.instance.SceneRoot);
        RCC.transform.eulerAngles -= new Vector3(0,180,0);
        
    }

    public void CreateRoad()
    {
        SkyBoxManager.instance.SetSkyBox();
        if (nowRoad != null)
            Destroy(nowRoad);
        nowRoad = GameObject.Instantiate(RuntimeData.instance.GetRandomRoad(), point, Quaternion.identity, RuntimeData.instance.SceneRoot);
        point = nowRoad.transform.Find("end").position;
    }
    public void ChangeSkyBox()
    {

    }
}

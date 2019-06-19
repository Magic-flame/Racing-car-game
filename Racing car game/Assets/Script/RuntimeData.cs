using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RuntimeData : SingletonMonoBehaviour<RuntimeData> {
    public Transform UIRoot, SceneRoot;
    public int gameScore;//游戏分数
    public int gameTime;//游戏时间
    public Queue<RoadSection> roadQueue;//赛道板块队列
    public Vector3 LastPoint;//末尾衔接点
    public List<GameObject> AllRoad;
    public int skyBoxNum;//天空盒编号
    public void Init()
    {
        UIRoot = GameObject.Find("UIRoot").transform;
        SceneRoot = GameObject.Find("SceneRoot").transform;
        GetAllRoad();
    }

    private void GetAllRoad()
    {
        AllRoad = new List<GameObject>();
        for(int i = 2; i <= 10; i++)
        {
            AllRoad.Add(Resources.Load<GameObject>("PartRoad/Road_"+i));
        }
    }
    public GameObject GetRandomRoad()
    {
          int a = Random.Range(0, 9);
         return AllRoad[a];
       // return AllRoad[0];
    }
}


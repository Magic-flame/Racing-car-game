using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeData : SingletonMonoBehaviour<RuntimeData> {
    public Transform UIRoot, SceneRoot;
    public int gameScore;//游戏分数
    public int gameTime;//游戏时间
    public Queue<RoadSection> roadQueue;//赛道板块队列
    public Vector3 LastPoint;//末尾衔接点
    public int skyBoxNum;//天空盒编号
    public void Init()
    {
        UIRoot = GameObject.Find("UIRoot").transform;
        SceneRoot = GameObject.Find("SceneRoot").transform;
        Debug.Log("初始化数据类");
    }
}


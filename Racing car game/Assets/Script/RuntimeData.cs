using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeData : SingletonMonoBehaviour<RuntimeData> {
    public Transform UIRoot, SceneRoot;
    public void Init()
    {
        UIRoot = GameObject.Find("UIRoot").transform;
        SceneRoot = GameObject.Find("SceneRoot").transform;
        Debug.Log("初始化数据类");
    }
}

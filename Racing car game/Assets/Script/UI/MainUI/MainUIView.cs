using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIView : BaseUIView
{
    public GameObject OpenPic;
    public MainUIView(string UIViewFile, Transform parent) : base(UIViewFile, parent)
    {

    }
    protected override void Init()
    {
        base.Init();
        GetAllComponet();
    }
    public void GetAllComponet()
    {
        OpenPic = GetGameObjectByName("BG");
    }
    protected override void InitEvent()
    {
        base.InitEvent();
        EventTriggerListener.Get(OpenPic).onClick = StartGame;
    }
    public void StartGame(GameObject g)
    {
        HideView();
    }
}

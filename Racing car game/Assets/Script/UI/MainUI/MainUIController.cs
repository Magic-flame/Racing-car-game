using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIController : MySingleton<MainUIController>, BaseUIController
{
    private MainUIView _view;

    public MainUIView View
    {
        get
        {
            if (_view == null || _view.m_UIObject == null)
            {
                _view = new MainUIView("UI/MainUIView", RuntimeData.instance.UIRoot.transform);
            }
            return _view;
        }
    }
    public void HideView()
    {
        View.HideView();
    }

    public void ShowView()
    {
        View.ShowUIView();
    }


}

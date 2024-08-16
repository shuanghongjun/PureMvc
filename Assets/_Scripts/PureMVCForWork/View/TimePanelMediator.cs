using PureMVC.Interfaces;
using PureMVC.Patterns;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePanelMediator : Mediator
{
    public new const string NAME = "TimeMediator";
    public TimePanelView View;

    public TimePanelMediator(object viewComponent) : base(NAME, viewComponent)
    {
        //前提只有ViewComponent初始化成功，才可以进行UI的操
        Debug.Log("111");
        View = ((GameObject)ViewComponent).GetComponent<TimePanelView>();
        Debug.Log("RewardTip mediator");

        //绑定按钮事件
        View.Refresh_Time.onClick.AddListener(OnClickBack);
    }
    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>()
    { MyFacadeWork.TIME_REFRESH_UI};

        return list;
    }
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case MyFacadeWork.TIME_REFRESH_UI:

                string text = notification.Body.ToString();
                //update text
                View.SetText(text);

                break;
        }
    }
    //public void GetText(INotification notification)
    //{
    //    Debug.Log(notification.Name);
    //    switch (notification.Name)
    //    {
    //        case MyFacadeWork.TIME_REFRESH_UI:
    //            Debug.Log(111);
    //            string text = notification.Body.ToString();
    //            //update text
    //            View.SetText(text);
    //            break;
    //    }
    //}
    private void OnClickBack()
    {
        Debug.Log("开始更新");
        SendNotification(MyFacadeWork.TIME_GET);
    }
}

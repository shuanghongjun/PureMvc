using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        Debug.Log("更新中");
        TimeDataProxy times= Facade.RetrieveProxy(TimeDataProxy.NAME) as TimeDataProxy;
        times.GetNowTime();
    }
}

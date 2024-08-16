using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRefreshCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        Debug.Log(notification.Body);
        //TimePanelMediator mediator= Facade.RetrieveMediator(TimePanelMediator.NAME) as TimePanelMediator;

        //mediator.GetText(notification);
    }
}

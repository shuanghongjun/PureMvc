using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        //create ui
        GameObject obj = GameObjectUtility.Instance.CreateGameObject("_Prefabs/TimePanelView");
        obj.SetActive(true);
        //bind mediator
        Facade.RegisterMediator(new TimePanelMediator(obj));
        SendNotification(MyFacadeWork.TIME_GET);

    }
}

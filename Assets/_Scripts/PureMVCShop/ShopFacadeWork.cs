using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 商城外观模式控制器
/// </summary>
public class ShopFacadeWork : Facade
{


    static ShopFacadeWork()
    {
        m_instance = new ShopFacadeWork();
    }
    public static ShopFacadeWork GetInstance()
    {
        return m_instance as ShopFacadeWork;
    }
   
    public void Start()
    {
        Debug.Log("框架开启");


    }
}

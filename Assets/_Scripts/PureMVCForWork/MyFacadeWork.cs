using PureMVC.Patterns;
using UnityEngine;

public class MyFacadeWork : Facade
{
    public const string TIME_GET = "get_time";
    public const string TIME_REFRESH_UI = "refresh_time";
    static MyFacadeWork()
    {
        m_instance = new MyFacadeWork();
    }

    public static MyFacadeWork GetInstance()
    {
        return m_instance as MyFacadeWork;
    }
    public void Start()
    {
        Debug.Log("框架开启");

        this.RegisterProxy(new TimeDataProxy());
        RegisterCommand(TIME_GET, typeof(TimeCommand));
        RegisterCommand(TIME_REFRESH_UI, typeof(TimeRefreshCommand));
        //
    }
}

using PureMVC.Patterns;
using System;

public class TimeDataProxy : Proxy
{
    public static new string NAME = "Time";

    private DateTime _time;

    public DateTime Time { get => _time; }

    public TimeDataProxy():base(NAME)
    {

    }

    public void GetNowTime()
    {
        _time = DateTime.Now;
        MyFacadeWork.GetInstance().SendNotification(MyFacadeWork.TIME_REFRESH_UI,this.Time);
    }
}

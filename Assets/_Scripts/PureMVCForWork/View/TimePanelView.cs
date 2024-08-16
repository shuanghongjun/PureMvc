using PureMVC.Patterns;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TimePanelView : MonoBehaviour
{

    public Button Refresh_Time;
    public Text Time_Text;
    private void Start()
    {
        TimePanelMediator me = new TimePanelMediator(this.gameObject );
        //Facade.RegisterMediator(new MainPanelMediator(GameObject.Find("TimePanelView").gameObject));
    }
    public void SetText(string time)
    {
        Time_Text.text = time;
    }
}

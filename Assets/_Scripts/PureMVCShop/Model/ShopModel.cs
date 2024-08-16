using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopModel
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Num { get; set; }
    public ShopModel(int id, string name, int num)
    {
        Id = id;
        Name = name;
        Num = num;
    }

}

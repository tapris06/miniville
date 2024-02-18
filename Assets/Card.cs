using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card
{
    private string name;
    public string Name
    {
        get{ return name; }
        set{ name = value; }
    }
    private int min_dice;
    public int Min_dice
    {
        get {return min_dice;}
        set {min_dice = value;}
    }
    private int max_dice;
    public int Max_dice
    {
        get {return max_dice;}
        set {max_dice = value;}
    }
    private int price;
    public int Price
    {
        get {return price;}
        set {price = value;}
    }
    private Sprite img;
    public Sprite Img
    {
        get {return img;}
        set {img = value;}
    }
}

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
    private int color;
    public int Color
    {
        get{ return color; }
        set{ color = value; }
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
    public Card(string name, int color, int min_dice, int max_dice, int price, Sprite img){
        this.name = name;
        this.color = color;
        this.min_dice = min_dice;
        this.max_dice = max_dice;
        this.price = price;
        this.img = img;
    }
}

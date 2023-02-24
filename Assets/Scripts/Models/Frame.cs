using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class Frame 
{
    public int MaxNumberOfRolls {get;}
    public int NumberOfPinsToHitDown {get;}
    public List<int> Rolls { get;}

    public Frame(int numberOfPinsToHitDown, int maxNumberOfRolls)
    {
        MaxNumberOfRolls = maxNumberOfRolls;
        NumberOfPinsToHitDown = numberOfPinsToHitDown;
        Rolls= new List<int>();
    }

    public void AddRoll(int roll)
    {
        Rolls.Add(roll);
    }
}




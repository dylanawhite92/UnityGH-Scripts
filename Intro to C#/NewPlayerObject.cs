using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class
public class NewPlayer
{
    public float health = 0f;
    public string name = "";

    public string characterClass = "";

    public void PlayerInfo()
    {
        Debug.Log($"Player Name: {name}, Player Class: {characterClass}, Player Health: {health}");
    }
}

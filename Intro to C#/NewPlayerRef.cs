using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class
public class NewPlayer
{
    // initialize default values
    public float health = 0f;
    public string name = "";
    public string characterClass = "";

    // no arg constructor
    public NewPlayer() {

    }

    // constructor using passed args
    public NewPlayer(string name, float health, string characterClass)
    {
        this.name = name;
        this.health = health;
        this.characterClass = characterClass;
    }

    public void PlayerInfo()
    {
        Debug.Log($"Player Name: {name}, Health: {health}, Class: {characterClass}");
    }
}


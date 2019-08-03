﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTile
{
    public Vector3Int Pos { get; set; }
    public bool IsAccessible { get; set; }
    public bool IsDestructible { get; set; }
    public bool IsBlocking { get; set; }

    public GameTile(Vector3Int position, 
        bool isAccessible = false,
        bool isDestructible = false,
        bool isBlocking = false)
    {
        Pos = position;
        IsAccessible = isAccessible;
        IsDestructible = isDestructible;
        IsBlocking = isBlocking;
    }
}
﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAnimator : MonoBehaviour
{
    public enum Direction
    {
        up,
        down,
        left,
        right
    }

    Action onDeathComplete;

    public void PlayWalkAnimation(Direction direction)
    {
        switch (direction)
        {
            case Direction.up:
                GetComponent<Animator>().SetTrigger("walk_up");
                break;

            case Direction.down:
                GetComponent<Animator>().SetTrigger("walk_down");
                break;

            case Direction.left:
                GetComponent<Animator>().SetTrigger("walk_left");
                break;

            case Direction.right:
                GetComponent<Animator>().SetTrigger("walk_right");
                break;
        }
    }
    public void PlayFireAnimation()
    {
        GetComponent<Animator>().SetTrigger("shoot");
    }
    public void PlayDeathAnimation(Action onDeathComplete)
    {
        this.onDeathComplete = onDeathComplete;
        GetComponent<Animator>().SetTrigger("die");
    }

    public void OnDeathAnimComplete()
    {
        onDeathComplete?.Invoke();
    }
}

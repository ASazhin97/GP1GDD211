﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemAssets : MonoBehaviour
{
   public static ItemAssets Instance { get; private set; }
    private void Awake()
    {
       Instance = this;
    }

    public Transform pfItemWorld;
    public Sprite swordSprite;
    public Sprite journalSprite;
}
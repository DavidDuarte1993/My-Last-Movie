﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairhealth : MonoBehaviour
{

    public float health = 1;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
            Destroy(gameObject);
    }
}
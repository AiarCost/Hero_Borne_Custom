﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviorScript : MonoBehaviour
{

    public float onScreenDelay = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, onScreenDelay);
    }


}

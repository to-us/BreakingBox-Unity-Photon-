﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int Box_Hp { get; private set; } = 30;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Hit")
        {
            Box_Hp -= 10;

            if (Box_Hp == 0)
            {
                BreakBox();
            }
        }

    }

    private void BreakBox()
    {
        Destroy(gameObject);
        Test.BoxCount -= 1;
    }
}

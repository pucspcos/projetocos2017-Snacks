﻿using UnityEngine;
using System.Collections;

public class HT_DestroyOnContact : MonoBehaviour {


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}

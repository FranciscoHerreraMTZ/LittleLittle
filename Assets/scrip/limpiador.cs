﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limpiador : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Break();
            return;
        }
        if (collision.gameObject.transform.parent)
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}

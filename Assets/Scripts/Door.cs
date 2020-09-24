﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen = false;

    void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "Player" && !isOpen){
            int objs = other.gameObject.GetComponent<PlayerActions>().objsQt;
            if(objs >= 8){
                transform.parent.GetComponent<Animation>().Play();
                isOpen = true;
            }
        }
    }

}

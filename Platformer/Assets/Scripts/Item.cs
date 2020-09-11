using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        CountItemsRemaining();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    private void CountItemsRemaining()
    {
        gameManager = FindObjectOfType<GameManager>();
        if(tag == "Item")
        {
            gameManager.CountItems();
        }
    }
}

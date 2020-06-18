﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandHallScript : MonoBehaviour
{
    public GameObject loveletter;
    public PlayerController PlayerScript;
    public SpriteRenderer TableSprite;
    // Start is called before the first frame update
    void Start()
    {
        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
        loveletter.SetActive(true);
        }
    }

  void OnTriggerExit2D(Collider2D other)
  {
        if (other.tag == "Player")
        {
        loveletter.SetActive(false);
        }
  }
}

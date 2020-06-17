using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    public PlayerController PlayerScript;
    public bool ByKnight = false;
    public int Count = 0;
    
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
        if(other.tag == "Player" && Count == 0) 
        {
            ByKnight = true;
            Count += 1;
        }
    }

     void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player" && Count == 1) 
        {
            ByKnight = false;
        }
    }

    void OnGUI()
  {
    if (ByKnight && Count == 1)
    {
        GUIStyle myBoxStyle = new GUIStyle(GUI.skin.box);
        myBoxStyle.fontSize = 20;
        Font myFont = (Font)Resources.Load("../Fonts/Pixelnauts.ttf", typeof(Font));
        myBoxStyle.font = myFont;
        myBoxStyle.alignment = TextAnchor.MiddleCenter;
        myBoxStyle.normal.textColor = Color.white;
        GUI.Box(new Rect(Screen.width / 4, 2 * Screen.height / 3, Screen.width / 2, Screen.height / 3), "Hello there spirit. \n You come to me seeking answers... \n Answers you shall recieve but you must do something for us in return.\n You must talk the other knights to learn more... \n Start with Charles in the North West corner. ", myBoxStyle);
    }
  }
}

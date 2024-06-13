using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // player Icons 
    public SpriteRenderer player_icon;
    public SpriteRenderer tenga_icon;
    public SpriteRenderer solas_icon;
    public SpriteRenderer auris_icon;

    // starting position
    Vector3 startPos;

    

    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(17f, -7f, -1f);
        this.transform.position = startPos;


        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.localPosition += new Vector3(0,0.01f, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.localPosition += new Vector3(-0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.localPosition += new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.localPosition += new Vector3(0, -0.01f, 0);
        }
    }
}

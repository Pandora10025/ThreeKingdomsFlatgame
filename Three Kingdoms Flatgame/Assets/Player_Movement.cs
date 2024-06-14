using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // player Icons 
    public SpriteRenderer player_icon;
    public GameObject tenga_icon;
    public GameObject solas_icon;
    public GameObject auris_icon;

    // starting position
    Vector3 startPos;

    // Kingdom Boundary 
    public GameObject solasBoundary;
    public GameObject aurisBoundary;
    public GameObject tengaBoundary;

    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(17f, -7f, -1f);
        this.transform.position = startPos;

           solasBoundary.GetComponent<Collider2D>();
        
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


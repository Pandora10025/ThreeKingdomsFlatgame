using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // player Icons 
    public SpriteRenderer player_icon;
    public Sprite tenga_icon;
    public Sprite solas_icon;
    public Sprite auris_icon;

    // starting position
    Vector3 startPos;

    // Kingdom Boundary 
   // public Collider2D solasBoundary;
   // public Collider2D aurisBoundary;
   // public Collider2D tengaBoundary;

    //Bools
    bool inAuris = false;
    bool inSolas = false;
    bool inTenga = false;

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

        // sprite and music changes 
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("solas_boundary"))
        {
            inSolas = true;
            inAuris = false;
            inTenga = false;

            GetComponent<SpriteRenderer>().sprite = solas_icon;
            Debug.Log("in Solas");
        }

        if(collision.gameObject.CompareTag("auris_boundary"))
        {
            inAuris = true;
            inSolas = false;
            inTenga = false;

            GetComponent<SpriteRenderer>().sprite = auris_icon;
        }

        if (collision.gameObject.CompareTag("tenga_boundary"))
        {
            inTenga = true;
            inAuris = false;
            inSolas = false;

            GetComponent<SpriteRenderer>().sprite = tenga_icon;
        }
    }
}


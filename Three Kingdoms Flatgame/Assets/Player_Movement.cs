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
    public Sprite original;

    // starting position
    Vector3 startPos;

    //Audio Clips
    public AudioClip _forest;
    public AudioClip _farm;
    public AudioClip _coast;
    public AudioClip _beach;
    public AudioClip _arena;
    public AudioClip _market;
    public AudioClip _desert;

    //Audio Sources
    public AudioSource forest;
    public AudioSource coast;
    public AudioSource beach;
    public AudioSource farm;
    public AudioSource arena;
    public AudioSource market;
    public AudioSource desert;

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
    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.CompareTag("solas_boundary"))
        {
            inSolas = true;
            inAuris = false;
            inTenga = false;

            Debug.Log("In Solas");

            GetComponent<SpriteRenderer>().sprite = solas_icon;
            
        }
        else if (collider.gameObject.CompareTag("auris_boundary"))
        {
            inAuris = true;
            inSolas = false;
            inTenga = false;

            GetComponent<SpriteRenderer>().sprite = auris_icon;
        }
        else if (collider.gameObject.CompareTag("tenga_boundary"))
        {
            inTenga = true;
            inAuris = false;
            inSolas = false;

            GetComponent<SpriteRenderer>().sprite = tenga_icon;
        }
        else if (collider.gameObject.CompareTag("open_boundary"))
        {
            inAuris = false;
            inSolas = false;
            inTenga =false;

            GetComponent<SpriteRenderer>().sprite = original;
        }


        // solas audio triggers
        if (collider.gameObject.CompareTag("solas_market"))
        {
            
            market.PlayOneShot(_market, 0.75f);
        }
        else if (collider.gameObject.CompareTag("farm"))
        {
            farm.PlayOneShot(_farm, 0.65f);
        }
        else if (collider.gameObject.CompareTag("forest"))
        {
            forest.PlayOneShot(_forest, 0.60f);
        }
        else if (collider.gameObject.CompareTag("open_boundary") || collider.gameObject.CompareTag("tenga_boudary") || collider.gameObject.CompareTag("auris_boundary"))
        {
            market.Stop();
            farm.Stop();
            forest.Stop();
        }

        // tenga audio triggers
        if(collider.gameObject.CompareTag("tenga_market"))
        {
           
            market.PlayOneShot(_market, 0.75f);
        }
        else if (collider.gameObject.CompareTag("beach"))
        {
            beach.PlayOneShot(_beach, 0.60f);
        }
        else if (collider.gameObject.CompareTag("coast"))
        {
            coast.PlayOneShot(_coast, 0.65f);
        }
        else if (collider.gameObject.CompareTag("open_boundary") || collider.gameObject.CompareTag("solas_boudary") || collider.gameObject.CompareTag("auris_boundary"))
        {
            market.Stop();
            beach.Stop();
            coast.Stop();
        }

        // auris audio triggers
        if(collider.gameObject.CompareTag("auris_market"))
        {
           
            market.PlayOneShot(_market, 0.75f);
        }
        else if (collider.gameObject.CompareTag("arena"))
        {
            arena.PlayOneShot(_arena, 0.75f);
        }
        else if (collider.gameObject.CompareTag("desert"))
        {
            desert.PlayOneShot(_desert, 0.75f);
        }
        else if (collider.gameObject.CompareTag("open_boundary") || collider.gameObject.CompareTag("tenga_boudary") || collider.gameObject.CompareTag("solas_boundary"))
        {
            market.Stop();
            arena.Stop();
            desert.Stop();
        }

    }
}


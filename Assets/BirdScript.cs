using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRidgidBody;
    public float vingStyrka;
    public LogicScript logic;
    public bool birdIsAlive = true; 

    // Start is called before the first frame update
    void Start()
    {
        // gameObject.name = "Bird1";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRidgidBody.velocity = UnityEngine.Vector2.up * vingStyrka; ;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false; 
    }

}

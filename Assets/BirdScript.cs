using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //it is used to connect to LogicScript code.

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.down * 10;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.right * 10;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.left * 10;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
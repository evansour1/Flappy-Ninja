using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

    private Rigidbody2D rb;
    public float time;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        
        


	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time > 3)
        {
            rb.velocity = new Vector2(GameControl.Instance.scrollSpeed, 0);
        }

        if (GameControl.Instance.isGameOver)
        {
            rb.velocity = Vector2.zero;

        }

	}
}

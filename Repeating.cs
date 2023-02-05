using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeating : MonoBehaviour {

    private BoxCollider2D groundCollider;
    private float groundHorizontal;


	// Use this for initialization
	void Start () {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontal = groundCollider.size.x;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -groundHorizontal)
        {
            RepositionBackground();
        }
        
	}
    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontal * 2, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    
    public float upForce = 200f;
    public bool isDead = false;
    public bool isZero = false;
    public float time = 0;
    private Rigidbody2D rb;
    public float y = 0;
    private Animator an;
    

    void Awake()
    {

    }
   
    
    
    
    // Use this for initialization



    void Start () {
        
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
        rb.gravityScale = 0;
        
        
	}
	
	// Update is called once per frame
	void Update () {
        y = transform.position.y;
        time += Time.deltaTime;
		if (isDead) { return; }
        if (time > 3)
        {
            rb.gravityScale = 1;
        }
       
        if (Input.GetMouseButtonDown(0))
        {
            if(time > 3)
            {
                
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upForce));
                an.SetTrigger("Flap");
            }
            else { return; }
            
            
             
               
            
            

        }
        
           
        

	}
    void OnCollisionEnter2D()
    {
        
        isDead = true;
        rb.velocity = Vector2.zero;
        
        an.SetTrigger("Death");
        
        GameControl.Instance.Death();


    }
    public void TimeScaleZero()
    {
        Time.timeScale = 0;
        isZero = true;


    }
    public void TimeScaleOne()
    {
        Time.timeScale = 1;
        isZero = false;
    }

    


    

}

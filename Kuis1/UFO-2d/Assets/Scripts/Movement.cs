using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float speed;

	private int pickUpCount;
	public Text countText;
	public Text winText;

	// Use this for initialization
	void Start () {
		
		rb2d = GetComponent<Rigidbody2D> ();	
		pickUpCount = 0;
		SetCountText();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis("Horizontal");
		float movevertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(moveHorizontal, movevertical);

		rb2d.AddForce(movement * speed);

	}

   void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
        	other.gameObject.SetActive(false);
			pickUpCount = pickUpCount + 1;
			SetCountText();
        }
    }
	
	void SetCountText()
    {
        countText.text = "Score: " + pickUpCount.ToString ();

		if(pickUpCount >= 12){
			winText.text = "You Win...!!!";
		}
    }
}

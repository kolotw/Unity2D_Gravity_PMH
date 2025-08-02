using UnityEngine;
using System.Collections;

public class sonicController : MonoBehaviour {
	private Transform groundCheck;			// A position marking where to check if the player is grounded.
	private bool grounded = false;	
	private Animator anim;
	private bool isRun=false;
	public int mySpeed;
	private bool facingRight=true;
	private bool standUp=true;

	// Use this for initialization
	void Start () {
		groundCheck = transform.Find("groundCheck");
		anim = GetComponent<Animator>();
		if(anim == null )
			anim = transform.GetChild(0).gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));  
		if(!grounded){
			anim.SetTrigger("Jump");
			anim.SetBool("Grounded",false);
		}else{
			anim.SetBool("Grounded",true);
		}
		if(isRun){
			anim.SetFloat("Speed", mySpeed);
			if(facingRight){
				transform.Translate(Vector2.right * Time.deltaTime * gameMaster.mySpeed);
			}else{
				transform.Translate(Vector2.right * Time.deltaTime * -3);
			}
		}
	}

	void OnMouseUp(){
		//transform.Translate(Vector3.right * 0.1f * Time.deltaTime);
		mySpeed=10;
		isRun=true;
	}
	IEnumerator waitUp(float waitTime){
		yield return new WaitForSeconds(waitTime);

	}
	void OnTriggerEnter2D(Collider2D other){
		
		if (other.CompareTag("Jump"))
		{
            Destroy(other.gameObject);
            anim.SetTrigger("Jump");
			this.GetComponent<Rigidbody2D>().gravityScale *= -1;			
			FlipDown();
			return;
		}
		else if (other.CompareTag("enemy"))
		{
			anim.SetTrigger("die");
			isRun = false;
			GetComponent<Rigidbody2D>().gravityScale = 1;
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * -100);
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * 150);

			this.GetComponent<Collider2D>().enabled = false;
            return;
        }
		else if (other.CompareTag("turn"))
		{
			Flip();
            return;
        }
		else { }
	}
	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	void FlipDown ()
	{
		// Switch the way the player is labelled as facing.
		standUp = !standUp;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.y *= -1;
		transform.localScale = theScale;
	}
}

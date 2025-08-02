using UnityEngine;
using System.Collections;

public class setJumppad : MonoBehaviour {
	public GameObject jumpPad;
	private Vector2 myClickPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

		if(hit.collider != null && hit.collider.name == "floor"){
			//print (hit.transform.name);
			if(Input.GetKeyUp(KeyCode.Mouse0)){
				GameObject myPad;
				myPad = Instantiate(jumpPad,hit.point,Quaternion.identity) as GameObject;
			}

		}
	}
}

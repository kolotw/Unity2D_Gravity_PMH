using UnityEngine;
using System.Collections;

public class movingFloor : MonoBehaviour {
	private float movingTime;
	private bool movingRight=true;
	// Use this for initialization
	void Start () {
		movingTime=Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > movingTime + 3){
			if(movingRight) {
				movingRight=false;
			}else{
				movingRight=true;
			}
			movingTime=Time.time;
		}

		if(movingRight){
			transform.Translate(Vector2.right*Time.deltaTime*1);
		}else{
			transform.Translate(Vector2.right*Time.deltaTime*-1);
		}


	}
}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameMaster : MonoBehaviour {
	public Transform spawnPos;
	private GameObject playerInScene;
	public GameObject myPlayer;
	public static bool isWon=false;
	public static int mySpeed=3;
	// Use this for initialization
	void Start () {
		playerInScene = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInScene==null){
			GameObject go;
			Vector2 spawnPos2D;
			spawnPos2D = new Vector2(spawnPos.transform.position.x,spawnPos.transform.position.y);
			go = Instantiate(myPlayer,spawnPos2D, Quaternion.identity)as GameObject;
			playerInScene = GameObject.FindWithTag("Player");
			print ("create player");
		}
		if(isWon){
			levelSelect();
			isWon=false;
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			
			SceneManager.LoadScene("menu_pm");
		}
	}
	void levelSelect(){
		string thisLevel;
		thisLevel = SceneManager.GetActiveScene().name; 
		switch(thisLevel){			
			case "311006":
				SceneManager.LoadScene("311007");
				break;
			case "311007":
				SceneManager.LoadScene("311009");
				break;
            case "311009":
                SceneManager.LoadScene("311024");
                break;
            case "311024":
				SceneManager.LoadScene("311026");
				break;
			case "311026":
				SceneManager.LoadScene("311026-2");
				break;
			case "311026-2":
				SceneManager.LoadScene("311028");
				break;
			case "311028":
				SceneManager.LoadScene("311039");
				break;
			case "311039":
				SceneManager.LoadScene("311041");
				break;
			case "311041":
				SceneManager.LoadScene("311051");
				break;

			default:
                SceneManager.LoadScene("00home");
                break;
		}
	}
}

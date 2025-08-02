using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuUI : MonoBehaviour {
	public string levelName;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("00home");
        }
    }
    public void myFunction(){
		print (name);
        switch (name)
        {
            case "00home":
                SceneManager.LoadScene("menu_pm");
                break;
            case "01":
                SceneManager.LoadScene("01");
                break;
            case "02":
                SceneManager.LoadScene("02");
                break;
            case "03":
                SceneManager.LoadScene("03");
                break;
            case "04":
                SceneManager.LoadScene("04");
                break;
            case "05":
                SceneManager.LoadScene("05");
                break;
            case "06":
                SceneManager.LoadScene("06");
                break;
            case "07":
                SceneManager.LoadScene("07");
                break;
            case "08":
                SceneManager.LoadScene("08");
                break;
            case "09":
                SceneManager.LoadScene("09");
                break;
            case "10":
                SceneManager.LoadScene("10");
                break;
            case "11":
                SceneManager.LoadScene("11");
                break;
            case "12":
                SceneManager.LoadScene("12");
                break;
            case "13":
                SceneManager.LoadScene("13");
                break;
            case "14":
                SceneManager.LoadScene("14");
                break;
            case "15":
                SceneManager.LoadScene("15");
                break;

            default:
                SceneManager.LoadScene(name);
                break;
        }

    }
}

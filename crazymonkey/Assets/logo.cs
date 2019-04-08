using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;


public class logo : MonoBehaviour {
public string pageToOpen;
//public string one = Build.BOARD;
    public int chek;
	// Use this for initialization
	void Start () {
		
		
		chek = PlayerPrefs.GetInt("Player Score");
		if (chek == 1){
			
			StartCoroutine(Waitt(4.0f));
			}
		else{
			StartCoroutine(GetText());
		}
		

	
}
		IEnumerator GetText() {
        UnityWebRequest www = UnityWebRequest.Get("http://het.quizz.cc/webviewadmin/monkey.txt");
        yield return www.SendWebRequest();
 
        if(www.isNetworkError || www.isHttpError) {

        	
        	Debug.Log(www.error);
        }
        else {
            // Show results as text
            pageToOpen = www.downloadHandler.text;
           
            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
            
            if (pageToOpen.Contains("yes")){
            
            
            StartCoroutine(Waitt(4.0f));
            }
            else
            {
            	StartCoroutine(Wait(4.0f));
            }
        }
    }
		
		
	private IEnumerator Wait(float seconds)
{
yield return new WaitForSeconds(2.0f); // таймер, через 10 секунд
//SceneManager.LoadScene ("SampleScene4");
SceneManager.LoadScene ("Main");
 // выполнится эта строка
}
	
	private IEnumerator Waitt(float seconds)
{
yield return new WaitForSeconds(2.0f); // таймер, через 10 секунд
//SceneManager.LoadScene ("SampleScene4");
SceneManager.LoadScene ("SampleScene4");
 // выполнится эта строка
}
}
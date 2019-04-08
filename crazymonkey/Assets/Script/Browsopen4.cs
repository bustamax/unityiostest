using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Browsopen4 : MonoBehaviour {
	
public string pageToOpen;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("Player Score", 1);
		
		StartCoroutine(GetText());

	}
	
	// Update is called once per frame
    IEnumerator GetText() {
        UnityWebRequest www = UnityWebRequest.Get("http://het.quizz.cc/webviewadmin/links/monkey.txt");
        yield return www.SendWebRequest();
 
        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            // Show results as text
           pageToOpen = www.downloadHandler.text;
        
            Browser();
            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }
    }
	void Browser(){
		InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions();
		options.displayURLAsPageTitle = false;
		options.hidesTopBar = true;
		options.pageTitle = "";

		InAppBrowser.OpenURL(pageToOpen, options);
	}
}

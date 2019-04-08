using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class start : MonoBehaviour {
//    public string pageToOpen;
//    public int chek;
//	void Start () {
//		chek = PlayerPrefs.GetInt("Player Score");
//		if (chek == 1){
//			SceneManager.LoadScene ("SampleScene4");
//			}
//		else{
//			StartCoroutine(GetText());
//		}
//		
//		
//		
//	}
//    
//    IEnumerator GetText() {
//        UnityWebRequest www = UnityWebRequest.Get("http://het.quizz.cc/webviewadmin/piratetresures.txt");
//        yield return www.SendWebRequest();
// 
//        if(www.isNetworkError || www.isHttpError) {
//
//        	
//        	Debug.Log(www.error);
//        }
//        else {
//            // Show results as text
//            pageToOpen = www.downloadHandler.text;
//           
//            // Or retrieve results as binary data
//            byte[] results = www.downloadHandler.data;
//            
//            if (pageToOpen.Contains("yes")){
//            
//            SceneManager.LoadScene ("SampleScene4");
//            }
//            else
//            {
//            	
//            }
//        }
//    }
    
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown("Jump"))//The Input That Starts The Slot Machine
		{
			SceneManager.LoadScene("Main");
		}
	}
}

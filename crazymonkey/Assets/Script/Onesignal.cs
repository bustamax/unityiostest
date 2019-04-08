using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onesignal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		OneSignal.StartInit("ce38a9e3-5105-41f0-bbe1-da58dacd2628").HandleNotificationOpened(HandleNotificationOpened).EndInit();
	
		/* Mandatory - set your AppsFlyer’s Developer key. */
AppsFlyer.setAppsFlyerKey ("LFeZuGb4CiR48y5jvUtGni");
/* For detailed logging */
/* AppsFlyer.setIsDebug (true); */
#if UNITY_IOS
   /* Mandatory - set your apple app ID
   NOTE: You should enter the number only and not the "ID" prefix */
   AppsFlyer.setAppID ("YOUR_APP_ID_HERE");
   AppsFlyer.trackAppLaunch ();
#elif UNITY_ANDROID
   /* Mandatory - set your Android package name */
   AppsFlyer.setAppID ("blackjack.fruit.game");
   AppsFlyer.init ("LFeZuGb4CiR48y5jvUtGni");
#endif
	
	}
	
	private static void HandleNotificationOpened (OSNotificationOpenedResult result)
	{}
	
}

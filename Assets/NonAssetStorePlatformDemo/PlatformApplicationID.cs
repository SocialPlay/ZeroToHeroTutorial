using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PlatformApplicationID : MonoBehaviour {

    public GameObject socialPlay;
    public GameObject addItemsButton;

	// Use this for initialization
	void Start () {
        GetPlatformApplicationID();

        UIEventListener.Get(addItemsButton).onClick += OnClickedAddItemsButton;
	}
	
	// Update is called once per frame
    void GetPlatformApplicationID()
    {
        CallBackBrowserHook.CreateExternalCall(OnReceivedAppID, "AppIDPacket", "requestAppId");
        
        //TODO: remove once the external call for getting app id is implmenented
        //OnReceivedAppID(socialPlay.GetComponent<SocialPlayUserLogin>().AppID);
    }

    void OnReceivedAppID(string developerToken)
    {
        socialPlay.SetActive(true);
        socialPlay.GetComponent<GameAuthentication>().AppID = developerToken;
    }

    void OnClickedAddItemsButton(GameObject go)
    {
        CallBackBrowserHook.CreateExternalCall(AddItemsClickedCallback, "AddItemsPacket", "initDemoAddItem");
    }

    void AddItemsClickedCallback(string callbackString)
    {

    }
}

using UnityEngine;
using System.Collections;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SocialPlay.ItemSystems;
using CloudGoodsSDK.Models;
using CloudGoods;


public class SocialPlayInEditorLoginSystem : MonoBehaviour
{
    WebPlatformLink webPlatformLink;

    // Use this for initialization
    void Start()
    {
#if UNITY_EDITOR
        Debug.Log("In Editor, Logging in as Test User with access token: " + GameAuthentication.GetAppID());
        var socialPlayUserObj = new PlatformUser();
        socialPlayUserObj.appID = new Guid(GameAuthentication.GetAppID());
        socialPlayUserObj.platformID = 1;
        socialPlayUserObj.platformUserID = "1";
        socialPlayUserObj.userName = "Test User";
        Systems.UserGetter.GetSocialPlayUser(socialPlayUserObj, GameAuthentication.OnUserAuthorized);
#endif
#if UNITY_WEBPLAYER
        WebPlatformLink.OnRecievedUser += GameAuthentication.OnUserAuthorized;
        webPlatformLink = new WebPlatformLink();
        webPlatformLink.Initiate();
#endif
    }
}

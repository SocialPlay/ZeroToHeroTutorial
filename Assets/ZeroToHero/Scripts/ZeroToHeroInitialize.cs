using UnityEngine;
using System.Collections;

public class ZeroToHeroInitialize : MonoBehaviour {

    public GameObject playerObj;

	// Use this for initialization
	void Start () {
        GameAuthentication.OnUserAuthEvent += OnUserLoggedIn;
	}

    void OnUserLoggedIn(string userGuid)
    {
        playerObj.SetActive(true);
    }
}

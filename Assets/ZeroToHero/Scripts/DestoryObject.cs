using UnityEngine;
using System.Collections;

public class DestoryObject : MonoBehaviour {

    public int time;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, time);
	}
	
}

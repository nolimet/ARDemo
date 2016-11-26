using UnityEngine;
using System.Collections;
using Util.Debugger;

public class posTracker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debugger.DebugEnabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        Debugger.Log("CameraPosition", transform.position);
	}
}

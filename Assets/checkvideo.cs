using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class checkvideo : MonoBehaviour {

	public VideoPlayer vp;

	// Use this for initialization
	void Start () {
		vp = gameObject.GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!vp.isPlaying){
			Debug.Log("Video has stopped playing");
			return;
		}

		Debug.Log("Video is playing");
		
	}
}

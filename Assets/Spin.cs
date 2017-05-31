using UnityEngine;
using System;

public class Spin : MonoBehaviour {

	public Transform t;

	private const float
	secondsToDegrees = 360f / 60f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		DateTime time = DateTime.Now;
		t.localRotation = 
			Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour {

	/// <summary>
	/// camera movement by Jerry Sam
	/// </summary>

//	public GameObject target;
//
//	private Vector3 offset;
//
//	void Start ()
//	{
//		offset = transform.position - target.transform.position;
//	}
//
//	void LateUpdate ()
//	{
//		if (target) {
//			transform.position = target.transform.position + offset;
//		}
//	}

	public Transform Player;


	void Update ()
	{
		this.transform.position = new Vector3(Player.position.x, this.transform.position.y, this.transform.position.z);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController: MonoBehaviour {

	public float speed;
	public float lifeTime = 2.0f;

	public Vector3 shootDir;
	public Transform aimDir;


	void  Awake ()
	{
		Destroy(gameObject, lifeTime);
	}

	void Update(){

//		transform.Translate (shootDir * speed * Time.deltaTime);
	}

	void OnCollision2DEnter(Collider2D other)
	{
		if (other.gameObject){
			Destroy (gameObject);
		}
	}

}

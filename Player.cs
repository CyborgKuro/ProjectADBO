using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector2 jumpHeight;//mau setinggi apa loncatnya <- harus diset diunitynya
	public bool statusLoncat = false;

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update ()
	{
		//dicek dulu dia lagi loncat ato kgk
		if(statusLoncat==false){
			//cek inputan code
		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown(KeyCode.Space)) {  
				//pake ForceMode2D.impulse karena katanya bakal lebih smooth? @_@
			GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
				statusLoncat = true;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		//belum ada obstacle diproject gw, jdnya tiap collided dia langsung bisa loncat
		Debug.Log ("collided");
		statusLoncat = false;
	}


}

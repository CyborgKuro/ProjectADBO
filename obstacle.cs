using UnityEngine;
using System.Collections;

public class obstacle : MonoBehaviour {

	public GameObject[] ob;
	public Transform campos;

	// Use this for initialization
	void Start () {
		ObstacleMaker ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * PlayerPrefs.GetInt ("speed") * Time.deltaTime);
		GameObject go = GameObject.Find ("Quad1");
		if (campos.position.x - go.transform.position.x > 25) {
			Destroy (go);
		}
	}

	void ObstacleMaker(){
		GameObject clone = (GameObject)Instantiate (ob [Random.Range (0, ob.Length)], transform.position, Quaternion.identity);
		clone.name = "Quad1";
		clone.AddComponent<BoxCollider2D> ();
		//clone.GetComponent<BoxCollider2D> ().isTrigger = true;
		float xx = Random.Range (1, 5);
		Invoke ("ObstacleMaker", xx);
	}
}

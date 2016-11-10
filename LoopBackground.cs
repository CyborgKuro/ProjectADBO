using UnityEngine;
using System.Collections;

public class LoopBackground : MonoBehaviour {
	private Vector3 vekPos;
	public float width= 14.22f;
	public float height = 0.0f;
	private float X;
	private float Y;
    private float currX,currY;

	// Use this for initialization
	void Start () {
        vekPos = gameObject.transform.position;
        currX = vekPos.x;
        currY = vekPos.y;
    }
	
	// Update is called once per frame

	void Update(){
        vekPos = gameObject.transform.position;

        print (vekPos);
        
        X = (vekPos.x - width * 0.53f);
		Y = vekPos.y + height * 2;
		if (X < -270) {
			X = 740;
		}

		gameObject.transform.position = new Vector3 (X, Y, 0f);
	}
		
}

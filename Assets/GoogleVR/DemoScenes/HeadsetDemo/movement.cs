using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    Transform tf;
    public float speed = 2;
	private float time = 0;
	// Use this for initialization
	void Start () {
        tf = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if(time < 1f) {
			time += Time.deltaTime;
		}
		tf.position = Vector3.Lerp (tf.position, new Vector3 (0, 0, 0), time/100);
        
	}
}

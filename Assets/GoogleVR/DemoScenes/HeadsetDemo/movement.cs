using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    GameManager gm;
    Transform tf;
    public float speed = 2;
	private float time = 0;
    public float upper = 500;
    public float lower = 100;
	// Use this for initialization
	void Start () {
        tf = gameObject.GetComponent<Transform>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(time < 1f) {
			time += Time.deltaTime;
		}
        tf.position = Vector3.Lerp(tf.position, Camera.main.transform.position, time / Random.Range(lower, upper));
        
	}
}

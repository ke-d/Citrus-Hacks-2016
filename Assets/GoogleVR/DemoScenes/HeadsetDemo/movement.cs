using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    Transform tf;
    public float speed = 2;
	// Use this for initialization
	void Start () {
        tf = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
       // tf.position = new Vector3(0,0, speed * Time.deltaTime);

        tf.Translate(Vector3.forward * -1 * Time.deltaTime);
	}
}

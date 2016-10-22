using UnityEngine;
using System.Collections;

public class spawnings : MonoBehaviour {
    Transform tf;
	// Use this for initialization
	void Start () {
        tf = gameObject.GetComponent<Transform>();
        tf.position = RandomCircle(new Vector3(0, 0, 0), 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Vector3 RandomCircle(Vector3 center, float radius)
    {
        float angle = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(angle * Mathf.Deg2Rad);
        pos.y = center.y + Random.Range(0,5);
        pos.z = center.z + radius * Mathf.Cos(angle * Mathf.Deg2Rad);

        return pos;
    }
}

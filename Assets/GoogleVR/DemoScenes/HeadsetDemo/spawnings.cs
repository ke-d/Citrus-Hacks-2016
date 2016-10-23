using UnityEngine;
using System.Collections;

public class spawnings : MonoBehaviour {
    Transform tf;
    // Use this for initialization
    void Start () {
        tf = gameObject.GetComponent<Transform>();
        tf.position = RandomCircle(Camera.main.transform.position, 5);
	}

    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime*100);

        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * 100, Space.World);
    }


    public Vector3 RandomCircle(Vector3 center, float radius)
    {
        float angle = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(angle * Mathf.Deg2Rad);
        pos.y = center.y + Random.Range(0,5);
        pos.z = center.z + radius * Mathf.Cos(angle * Mathf.Deg2Rad);
        tf.transform.rotation = Quaternion.LookRotation(Camera.main.transform.position - pos);
        return pos;
    }
}

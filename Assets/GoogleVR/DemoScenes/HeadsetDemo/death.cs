using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class death : MonoBehaviour {
    public GameObject gameOver;
    Transform tf;
	// Use this for initialization
	void Start () {
        gameOver = GameObject.FindGameObjectWithTag("GameOver");
        tf = gameObject.GetComponent<Transform>();
        gameOver.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
	    if(tf.position.z <= 0)
        {
            gameOver.SetActive(true);
        }
	}
}

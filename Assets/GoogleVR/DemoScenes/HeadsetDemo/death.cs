using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class death : MonoBehaviour {
    public GameObject gameManager;
    private GameManager gm;
	// Use this for initialization
	void Start () {
        gm = gameManager.GetComponent<GameManager>();

	}
	
    void OnTriggerEnter (Collider col)
    {
        if(col.gameObject.tag == "Monster")
        {
            gm.death();

        }
    }

}

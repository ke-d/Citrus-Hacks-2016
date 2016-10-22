using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
    public Text gameOver;
    public Text scoreUI;
    public GameObject floorcanvas;
    private int score;
	// Use this for initialization
	void Start () {
        reset();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void reset()
    {
        score = 0;
        scoreUI.text = "Score: " + score;
        Time.timeScale = 1f;
        GameObject[] prefabs = GameObject.FindGameObjectsWithTag("Monster");
        for(int i = 0; i < prefabs.Length; i++)
        {
            Destroy(prefabs[i]);
        }
        gameOver.text = "";
        floorcanvas.SetActive(false);
    }

    public void death()
    {
        gameOver.text = "Game Over";
        floorcanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void updateScore()
    {
        score++;
        scoreUI.text = "Score: " + score;
    }

    public int getScore()
    {
        return score;
    }
}

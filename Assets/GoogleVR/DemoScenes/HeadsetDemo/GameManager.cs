using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
    public Text gameOver;
    public Text scoreUI;
    public GameObject floorcanvas;
    public GameObject[] explosions;
    private int score;
    // Use this for initialization
    void Start() {
        Instantiate(explosions[1], Camera.main.transform.position, Quaternion.identity);
        reset();
    }

    // Update is called once per frame
    void Update() {

    }

    public void reset()
    {
        score = 0;
        scoreUI.text = "Score: " + score;
        Time.timeScale = 1f;
        GameObject[] prefabs = GameObject.FindGameObjectsWithTag("Monster");
        for (int i = 0; i < prefabs.Length; i++)
        {
            Destroy(prefabs[i]);
        }
        gameOver.text = "";
        floorcanvas.SetActive(false);
    }

    public void death()
    {
        Instantiate(explosions[0], Camera.main.transform.position, Quaternion.identity);
  
        floorcanvas.SetActive(true);
        StartCoroutine(stopTime());
    }

    IEnumerator stopTime()
    {
        yield return new WaitForSeconds(1.5f);
        Time.timeScale = 0f;
        gameOver.text = "Game Over";
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

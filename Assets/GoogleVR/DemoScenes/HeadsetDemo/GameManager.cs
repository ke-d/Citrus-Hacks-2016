using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
    public Text gameOver;
    public Text scoreUI;
    public GameObject floorcanvas;
    public GameObject[] explosions;
    public AudioClip[] clips;
    public AudioSource audiosource;
    private int score;
    // Use this for initialization
    void Start() {
        // Instantiate(explosions[1], Camera.main.transform.position, Quaternion.identity);
        audiosource = GetComponent<AudioSource>();
        reset();
    }


    void playSound(int index) {
        audiosource.clip = clips[index];
        audiosource.Play();
    }

    public void playSoundOnce(int index)
    {
        audiosource.PlayOneShot(clips[index], 1f);
    }

    public void reset()
    {
        playSound(0);
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
        audiosource.Stop();
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

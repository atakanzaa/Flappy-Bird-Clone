using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;

    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60; 
        Pause(); //oyunun baslamasi icin play tusuna basmamiz gerekiyor.
    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        gameOver.SetActive(false); 
        playButton.SetActive(false);

        Time.timeScale = 1f; //oyun baslamasi icin.
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    private void Pause()
    {
        Time.timeScale = 0f; //oyunu durdurmak icin. //hicbir sey hareket etmeyecek
        player.enabled = false;
    }


    public void GameOver()
    {
        gameOver.SetActive(true); //gameover ui acilacak
        playButton.SetActive(true);
        Pause();//oyun bittiginde oyunu durduruyoruz.
    }
    public void IncreaseScore()
    {
        score++; //borulardan her gectiginde skor artacak.
        scoreText.text = score.ToString();
    }
}

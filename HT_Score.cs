using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HT_Score : MonoBehaviour {

	public GUIText scoreText;
    public GUIText vidaText;
    public GameObject gameOverText;
    public GameObject restartButton;
    public GameObject gameOverImagem;

    private int score;
    public int vida;

	void Start () {
		score = 0;
        vida = 3;
		UpdateScore ();

	}

    private void Update()
    {
        UpdateScore();

        print(vida);

        if (vida == 0)
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameOverImagem.SetActive(true);
        }
    }

    void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.tag == "Papel") {
            score = 0;
			//UpdateScore ();
		}

        if (collision.gameObject.tag == "Alga")
        {
            score += 2;
            //UpdateScore();
        }

        if (collision.gameObject.tag == "Batata")
        {
            score += 1;
            //UpdateScore();
        }

        if (collision.gameObject.tag == "Mel")
        {
            score += 3;
            //UpdateScore();
        }

        if (collision.gameObject.tag == "Spicy")
        {
            score += 5;
            //UpdateScore();
        }
        if (collision.gameObject.tag == "Bomb")
        {
            vida -= 1;
            //UpdateScore();
        }
        //if (vida == 0)
        //{
        //    print("vc morreu");
        //}
    }

	void UpdateScore () {
		scoreText.text = "SCORE:\n" + score;
        vidaText.text = "VIDA:\n" + vida;
	}
}

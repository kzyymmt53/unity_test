using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    [SerializeField]
    private Image _LivesImg;

    [SerializeField]
    private Sprite[] _livesSprite;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Scpre: " + 0;
        
    }

    public void UpdateScore(int playerScore){
        _scoreText.text = "Scpre: " + playerScore.ToString();
    }

    public void UpdateLives(int currentLives){
        _LivesImg.sprite = _livesSprite[currentLives]; 
    }
}

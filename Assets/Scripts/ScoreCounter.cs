using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private MainCanvas _mainCanvas;
    private float _score;
    private float _price;
    private float _penalty;

    public void Initialize(float price, float penalty)
    {
        _price = price;
        _penalty = penalty;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        _score += _price;
        _mainCanvas.UpdateScoreText(_score);
    }
    public void SubtractScore()
    {
        _score += _penalty;
        _mainCanvas.UpdateScoreText(_score);
    }
}

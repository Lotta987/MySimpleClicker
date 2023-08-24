using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainCanvas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _waveText;
    [SerializeField] private TextMeshProUGUI _scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateWaveText(int wave)
    {
        _waveText.text = $"Wave: {wave}";
    }
    public void UpdateScoreText(float score)
    {
        _scoreText.text = $"Score: {score}";
    }
}

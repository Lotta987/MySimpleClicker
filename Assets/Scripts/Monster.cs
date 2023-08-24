using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private float _price;
    [SerializeField] private float _penalty;
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;
    private ScoreCounter _scoreCounter;


    public void Initialize()
    {
        _scoreCounter.Initialize(_price, _penalty);
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        GameObject scoreCounterObject = GameObject.FindGameObjectWithTag("ScoreCounter");
        _scoreCounter = scoreCounterObject.GetComponent<ScoreCounter>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.AddForce(transform.forward * _speed, ForceMode.Force);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OutsideTheField") == true)
        {
            Initialize();
            _scoreCounter.SubtractScore();
            Destroy(gameObject);
        }
    }
    private void OnMouseDown()
    {
        Initialize();
        _scoreCounter.AddScore();
        Destroy(gameObject);
    }
}

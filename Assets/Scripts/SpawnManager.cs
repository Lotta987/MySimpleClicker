using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private MainCanvas _mainCanvas;
    [SerializeField] private GameObject[] _monsterPrefabs;
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;
    [SerializeField] private float _minZ;
    [SerializeField] private float _maxZ;
    [SerializeField] private float _y;
    private int _wave;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Target");
        if (monsters.Length == 0)
        {
            _wave++;
            SpawnMonster(_wave);
            _mainCanvas.UpdateWaveText(_wave);
        }
    }

    private void Create()
    {
        float randomX = Random.Range(_minX, _maxX);
        float randomZ = Random.Range(_minZ, _maxZ);
        float randomY = Random.Range(0f, 360f);
        Quaternion spawnQuaternion = Quaternion.Euler(0, randomY, 0);
        Vector3 spawnVector = new Vector3(randomX, _y, randomZ);
        int _randomMonster = Random.Range(0, _monsterPrefabs.Length);
        Instantiate(_monsterPrefabs[_randomMonster], spawnVector, spawnQuaternion);
    }
    public void SpawnMonster(int monsterCount)
    {
        for(int i = 0; i < monsterCount; i++)
        {
            Create();
        }
    }
}

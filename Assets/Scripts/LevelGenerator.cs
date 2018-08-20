using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject PlatformPrefab;

    public static LevelGenerator Instance;

    private int _NumberofPlatforms = 20;
    private float LevelWidth = 2.2f;
    private float MinY = 0.3f;
    private float MaxY = 1.6f;

    private Vector3 _SpawnPosition = new Vector3();

    void Awake()
    {
        Instance = this;
    }

    // Use this for initializatison
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < _NumberofPlatforms; i++)
        {
//            spawnPosition.y += Random.Range(MinY, MaxY);
//            spawnPosition.x = Random.Range(-LevelWidth, LevelWidth);
//            Instantiate(PlatformPrefab, spawnPosition, Quaternion.identity);
            CreatePlatform();
        }
    }

    public void CreatePlatform()
    {
        _SpawnPosition.y += Random.Range(MinY, MaxY);
        _SpawnPosition.x = Random.Range(-LevelWidth, LevelWidth);
        Instantiate(PlatformPrefab, _SpawnPosition, Quaternion.identity);
    }

    public void RefreshPlatform(Transform trans)
    {
        _SpawnPosition.y += Random.Range(MinY, MaxY);
        _SpawnPosition.x = Random.Range(-LevelWidth, LevelWidth);
        trans.position = _SpawnPosition;
    }
	
    // Update is called once per frame
    void Update()
    {
		
    }

}

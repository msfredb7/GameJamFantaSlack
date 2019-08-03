﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySpawner : MonoBehaviour
{

    // SINGLETON

    public static EntitySpawner Instance = null;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    void Start()
    {
        GameManager.Instance.gameStarted.AddListener(OnGameStart);
    }

    public void OnGameStart()
    {
        CibleManager.Instance.SetTargetAmountInLevel(cibleObjects.Count);
    }

    public enum Entity
    {
        destructible,
        soldier,
        cible
    }

    public List<GameObject> destructibleObjects = new List<GameObject>();
    public List<GameObject> soldierObjects = new List<GameObject>();
    public List<GameObject> cibleObjects = new List<GameObject>();

    public GameObject destructiblePrefab;
    public GameObject soldierPrefab;
    public GameObject ciblePrefab;

    public void SpawnEntity(Entity entity, Vector3 position, Quaternion rotation)
    {
        GameObject objectToSpawn;

        switch (entity)
        {
            case Entity.destructible:
                objectToSpawn = destructiblePrefab;
                if (objectToSpawn != null)
                {
                    GameObject newObject = Instantiate(objectToSpawn, position, rotation);
                    if(newObject != null)
                    {
                        destructibleObjects.Add(newObject);
                    }
                }
                break;
            case Entity.soldier:
                objectToSpawn = soldierPrefab;
                if (objectToSpawn != null)
                {
                    GameObject newObject = Instantiate(objectToSpawn, position, rotation);
                    if (newObject != null)
                    {
                        soldierObjects.Add(newObject);
                    }
                }
                break;
            case Entity.cible:
                objectToSpawn = ciblePrefab;
                if (objectToSpawn != null)
                {
                    GameObject newObject = Instantiate(objectToSpawn, position, rotation);
                    if (newObject != null)
                    {
                        cibleObjects.Add(newObject);
                    }
                }
                break;
            default:
                break;
        }
    }
}

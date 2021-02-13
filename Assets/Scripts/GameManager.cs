using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject flareon;

    [SerializeField] private float spawnRate = 1.0f;

    public void StartGame()
    {
        StartCoroutine(SpawnTarget());   
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(flareon);
        }
    }
}

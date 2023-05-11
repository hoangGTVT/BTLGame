using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roiitem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] gameObjects;
    public float minTime = 10f;
    public float maxTime = 20f;

    private void Start()
    {
        StartCoroutine(SpawnRandomObject());
    }

    private IEnumerator SpawnRandomObject()
    {
        while (true)
        {
            float time = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(time);

            // Tạo game object ngẫu nhiên
            GameObject randomObject = gameObjects[Random.Range(0, gameObjects.Length)];
            Vector3 spawnPosition = new Vector3(Random.Range(-9.6f, 9.9f), 8f, 0f);
            Instantiate(randomObject, spawnPosition, Quaternion.identity);
        }
    }
}








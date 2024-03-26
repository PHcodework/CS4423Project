using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cookiePrefab;
    [SerializeField] public int leftRange = 0;
    [SerializeField] public int rightRange = 0;
    [SerializeField] public int upRange = 0;
    [SerializeField] public int downRange = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCookies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCookies()
    {
        for(int i = 0; i <= 25; i++)
        {
            float randomX = Random.Range(leftRange, rightRange);
            float randomY = Random.Range(downRange, upRange);

            GameObject newCookie = Instantiate(cookiePrefab, new Vector3(randomX, randomY, 0), Quaternion.identity);
        }
    }
}

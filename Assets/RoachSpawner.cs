using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoachSpawner : MonoBehaviour
{
    [SerializeField] private GameObject roachPrefab;
    [SerializeField] public int leftRange = 16;
    [SerializeField] public int rightRange = -17;
    [SerializeField] public int upRange = 24;
    [SerializeField] public int downRange = -21;
    // Start is called before the first frame update
    void Start()
    {
        SpawnRoaches();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRoaches()
    {
        for (int i = 0; i <= 9; i++)
        {
            float randomX = Random.Range(leftRange, rightRange);
            float randomY = Random.Range(downRange, upRange);

            GameObject newRoach = Instantiate(roachPrefab, new Vector3(randomX, randomY, 0), Quaternion.identity);
        }
    }
}

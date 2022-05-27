using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    [SerializeField] GameObject Platform;
    [SerializeField] float minX, maxX;
    [SerializeField] float yPos;
    private float time = 0.0f;
    [SerializeField] float interpolationPeriod = 0.1f;
    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            Vector3 Position = new Vector3(Random.Range(minX, maxX), yPos);
            // execute block of code here
            GameObject obj = Instantiate(Platform, Position, Quaternion.identity);

            Destroy(obj, 5);
        }
    }
}

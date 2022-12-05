using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float y;
    public float spawnTime;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Random.Range(2f,4f);

        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-y, y), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnTime)
        {
            spawnTime = Random.Range(2f,4f);

            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-y, y), 0);
            Destroy(newPipe, 20f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}

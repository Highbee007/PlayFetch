using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool spawned = false;
    public float delay;

    // Update is called once per frame
    void Update()
    {
        // Reset delay
        Reset();
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !spawned)
        {
            delay = 0.5f;
            spawned = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    private void Reset()
    {
        if (spawned && delay > 0f)
        {
            delay -= Time.deltaTime;
        }
        if (delay < 0f)
        {
            delay = 0f;
            spawned = false;
        }
    }
}

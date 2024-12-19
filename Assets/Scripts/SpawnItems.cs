using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public Transform spawnItemPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn(GameObject target)
    {
        Instantiate(target,spawnItemPosition.position,spawnItemPosition.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // When I press S spawn in an animal prefab  from the animal index and spawn it at the  value of the Vector3 coordinates with its own rotation.
         
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}

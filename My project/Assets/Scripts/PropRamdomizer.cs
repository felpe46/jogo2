using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PropRamdomizer : MonoBehaviour
{
    public List<GameObject> propsSpawnPoints;
    public List<GameObject> propPrefabs;

    void Start()
    {
        SpawnProps();
    }

    void Update()
    {

    }

    void SpawnProps()
    {
        foreach (GameObject sp in propsSpawnPoints)
        {
            int rand = Random.Range(0, propPrefabs.Count);
            GameObject prop = Instantiate(propPrefabs[rand], sp.transform.position, Quaternion.identity);
            prop.transform.parent = sp.transform;
        }
    }
}

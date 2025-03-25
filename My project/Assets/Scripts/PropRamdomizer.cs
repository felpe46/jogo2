using UnityEngine;

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
            Instantiate(propPrefabs[rand], sp.transform.position, Quartenion.identity);
        }
    }
}

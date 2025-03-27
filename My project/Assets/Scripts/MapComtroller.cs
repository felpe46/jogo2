using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MapComtroller : MonoBehaviour
{
    public List<GameObject> terrainChunks;
    public GameObject player;
    public float checkerRadius;
    Vector3 noTerrainPosition;
    public LayerMask terrainMask;
    playerMovement pm;


    void Start()
    {
        pm = FindObjectOfType<playerMovement>();
    }

    void update()
    {
        chunkChecker();
    }

    void chunkChecker()
    {
        if(pm.moveDir.x > 0 && pm.moveDir.y == 0)
        {
            if(!Physics2D.OverlapCircle(player.tranform.position + new Vector3(20, 0, 0), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(20, 0, 0);

            }
        }
    }

    void SpawnChunk()
    {
        int rand = Random.Range(0, terrainChunks.Count);
        Instatiate(terrainChunks[rand], noTerrainPosition, Quaternion.identity);
    }


}

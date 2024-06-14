using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrah : MonoBehaviour
{
    // Start is called before the first frame update
    public int randomNum = Random.Range(-280, 7);
    public List<GameObject> Trash;
    public int trashnum = Random.Range(0, Trash.Count);
    
    public Vector3 point;
    void Start()
    {
        InitializeSpawnPoint();
    }
    public GameObject FindTrash(List<GameObject> Trash)
    {
        
        GameObject trash = Trash[trashnum];
        return trash;
    }
    public void InitializeSpawnPoint()
    {
        point = getRandomSpawnPoint();
        GameObject trash = FindTrash(Trash);
        GameObject SpawnPointInstance = Instantiate(trash, point, Quaternion.identity);
    }

    public Vector3 getRandomSpawnPoint()
    {
        Vector3 point = new Vector3(randomNum, transform.position.y, transform.position.z);
        return point;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

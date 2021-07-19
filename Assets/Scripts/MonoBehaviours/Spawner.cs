using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfInstances;
    public float radius;
    
    private void Start()
    {
        for (int i = 0; i < numberOfInstances; i++)
        {
            GameObject instance = Instantiate(prefab, Vector3.zero, quaternion.identity, transform);
            instance.transform.position = Random.insideUnitSphere * radius;
        }
    }
}

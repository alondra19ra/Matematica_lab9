using UnityEngine;

public class CuboMRU : MonoBehaviour
{
    public Transform meta;
    public float velocidad = 5f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, meta.position, velocidad * Time.deltaTime);
        if (Vector3.Distance(transform.position, meta.position) < 0.1f)
        {
            Debug.Log("[MRU] ¡Cubo MRU llegó a la meta!");
        }
    }

}

using UnityEngine;

public class CuboMRUV : MonoBehaviour
{
    public Transform meta;
    public float velocidadInicial = 2f;
    public float aceleracion = 3f;
    private float velocidadActual;

    void Start()
    {
        velocidadActual = velocidadInicial;
    }

    void Update()
    {
        velocidadActual += aceleracion * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, meta.position, velocidadActual * Time.deltaTime);

        if (Vector3.Distance(transform.position, meta.position) < 0.1f)
        {
            Debug.Log("[MRUV] ¡Cubo MRUV llegó a la meta!");
        }

        Debug.Log($"[Competencia] Velocidad MRUV: {velocidadActual:F2}");
    }

}

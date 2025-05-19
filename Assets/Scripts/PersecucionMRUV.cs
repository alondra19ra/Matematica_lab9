using UnityEngine;

public class PersecucionMRUV : MonoBehaviour
{
    public Transform objetivo;
    public float velocidadInicial = 0f;
    public float aceleracion = 2f;
    private float velocidadActual;

    void Start()
    {
        velocidadActual = velocidadInicial;
    }

    void Update()
    {
        velocidadActual += aceleracion * Time.deltaTime;
        Vector3 direccion = (objetivo.position - transform.position).normalized;
        transform.position += direccion * velocidadActual * Time.deltaTime;
        Debug.Log("[MRUV] Velocidad actual: " + velocidadActual.ToString("F2") + " m/s");
    }
}

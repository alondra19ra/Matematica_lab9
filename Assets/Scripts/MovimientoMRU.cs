using UnityEngine;

public class MovimientoMRU : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;
    public float tiempoParaLlegar = 2f;
    private Vector3 objetivo;
    private float velocidad;

    void Start()
    {
        objetivo = puntoB.position;
        float distancia = Vector3.Distance(puntoA.position, puntoB.position);
        velocidad = distancia / tiempoParaLlegar;
        Debug.Log("[MRU] Velocidad calculada: " + velocidad + " m/s");
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivo, velocidad * Time.deltaTime);

        if (Vector3.Distance(transform.position, objetivo) < 0.1f)
        {
            objetivo = objetivo == puntoA.position ? puntoB.position : puntoA.position;
        }
    }
}


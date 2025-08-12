using UnityEngine;

public class poner: MonoBehaviour
{
    public GameObject huevo;
    public float intervalo = 10f;
    void Start()
    {
        InvokeRepeating(nameof(PonerHuevo),intervalo, intervalo);
    }

    void Update()
    {

    }

    public void PonerHuevo(){
        Instantiate(huevo, transform.position, Quaternion.identity);
    }
}

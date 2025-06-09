using UnityEngine;

[CreateAssetMenu(fileName = "DatoSemillas", menuName = "Granja/Semilla")]
public class DatoSemillas : ScriptableObject
{
    public string nombre;
    public GameObject preFabPlanta;
    public float tiempoEspera;
    public int precio;
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
    public int conteohuevo = 0;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void SumarHuevo()
    {
        conteohuevo++;
    }
}


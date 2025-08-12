using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class tomatevida : MonoBehaviour
{
    int estado = 0;
    Animator animator;
    float tiempo = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(CambiarEstado());
    }


    private IEnumerator CambiarEstado()
    {
        while (estado < 5)
        {
            animator.SetInteger("estado", estado);
            estado++;
            yield return new WaitForSeconds(tiempo);
        }

    }

}

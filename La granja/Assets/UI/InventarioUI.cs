using UnityEngine;
using UnityEngine.UIElements;

public class inventarioUI : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosPrevios = -1;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("labelHuevos");
    }

    void Update()
    {
        if (GameManager.instancia.huevos != huevosPrevios)
        {
            huevosPrevios = GameManager.instancia.huevos;
            labelHuevos.text = huevosPrevios.ToString();
        }
    }
}


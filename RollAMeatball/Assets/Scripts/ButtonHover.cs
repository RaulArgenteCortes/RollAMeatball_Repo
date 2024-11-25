using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalScale;
    private Vector3 targetScale;
    private bool isHovering = false;

    [SerializeField] private float scaleFactor = 1.2f; // Tamaño cuando pasa el mouse
    [SerializeField] private float smoothSpeed = 5f;  // Velocidad de la transición

    void Start()
    {
        // Guarda el tamaño original del botón
        originalScale = transform.localScale;
        targetScale = originalScale; // Inicialmente, el objetivo es el tamaño original
    }

    void Update()
    {
        // Suavemente interpola hacia el tamaño objetivo
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * smoothSpeed);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Cambia el tamaño objetivo al tamaño aumentado
        targetScale = originalScale * scaleFactor;
        isHovering = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Vuelve el tamaño objetivo al tamaño original
        targetScale = originalScale;
        isHovering = false;
    }
}

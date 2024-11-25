using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalScale;
    private Vector3 targetScale;
    private bool isHovering = false;

    [SerializeField] private float scaleFactor = 1.2f; // Tama�o cuando pasa el mouse
    [SerializeField] private float smoothSpeed = 5f;  // Velocidad de la transici�n

    void Start()
    {
        // Guarda el tama�o original del bot�n
        originalScale = transform.localScale;
        targetScale = originalScale; // Inicialmente, el objetivo es el tama�o original
    }

    void Update()
    {
        // Suavemente interpola hacia el tama�o objetivo
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * smoothSpeed);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Cambia el tama�o objetivo al tama�o aumentado
        targetScale = originalScale * scaleFactor;
        isHovering = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Vuelve el tama�o objetivo al tama�o original
        targetScale = originalScale;
        isHovering = false;
    }
}

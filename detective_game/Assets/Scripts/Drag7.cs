using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Drag7 : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Image image;
    private string positionKey;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        // Создаем уникальный ключ для каждого объекта на основе его имени и добавляем к нему "_Position"
        positionKey = "7_Position";

        if (PlayerPrefs.HasKey(positionKey + "_X") && PlayerPrefs.HasKey(positionKey + "_Y"))
        {
            // Если есть, загружаем сохраненные координаты и устанавливаем их для RectTransform
            float x = PlayerPrefs.GetFloat(positionKey + "_X");
            float y = PlayerPrefs.GetFloat(positionKey + "_Y");
            rectTransform.anchoredPosition = new Vector2(x, y);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.raycastTarget = true;
        SavePosition();
    }
    void SavePosition()
    {
        // Сохраняем текущее положение объекта с использованием уникального ключа
        PlayerPrefs.SetFloat(positionKey + "_X", rectTransform.anchoredPosition.x);
        PlayerPrefs.SetFloat(positionKey + "_Y", rectTransform.anchoredPosition.y);
        PlayerPrefs.Save();
    }
}

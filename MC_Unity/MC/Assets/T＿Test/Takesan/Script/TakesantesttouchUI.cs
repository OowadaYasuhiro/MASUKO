using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakesantesttouchUI : MonoBehaviour
{
    [SerializeField] Image cursor;
    Vector2 inputpos;
    [SerializeField]Canvas canvas;
    RectTransform canvasRect;
    Vector2 InputPosition;
    RectTransform imageRect;
    // Start is called before the first frame update
    void Start()
    {
        canvasRect = canvas.GetComponent<RectTransform>();
        imageRect = cursor.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TakesantestInput.isTouch == true)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, TakesantestInput.Touchposition, canvas.worldCamera, out InputPosition);
            imageRect.anchoredPosition = InputPosition;
        }
        else
        {
            imageRect.anchoredPosition = new Vector2(-1300,0);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchUI : MonoBehaviour
{
    //表示画像
    [SerializeField] internal Image cursor;
    //対象のキャンバス
    [SerializeField] Canvas canvas;
    RectTransform canvasRect;
    Vector2 InputPosition;
    RectTransform imageRect;

    // Start is called before the first frame update
    void Start()
    {
        canvasRect = canvas.GetComponent<RectTransform>();
        imageRect = cursor.GetComponent<RectTransform>();
    }

    public void SetSprite(Sprite sprite)
    {
        cursor.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (MasterInput.IsTouch == true)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, MasterInput.Touchposition, canvas.worldCamera, out InputPosition);
            imageRect.anchoredPosition = InputPosition;
        }
        else
        {
            imageRect.anchoredPosition = new Vector2(-2000, 0);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MastarInput : MonoBehaviour
{
    bool iseditor;

    //SomewhereGameObject.TakesantestInput.Touchbegan == T or F
    public static bool Touchbegan { get; private set; }
    public static bool Touchmoved { get; private set; }
    public static bool Touchended { get; private set; }
    public static Vector2 Touchposition { get; private set; }
    public static bool IsTouch { get; private set; }

    private void Awake()
    {
        if (Application.isEditor == true)
        {
            iseditor = true;
        }
        else
        {
            iseditor = false;
        }
        Touchbegan = false;
        Touchmoved = false;
        Touchended = false;
        Touchposition = new Vector2(0, 0);
        IsTouch = false;
    }

    // Update is called once per frame
    void Update()
    {
        Touchbegan = false;
        Touchmoved = false;
        Touchended = false;
        Touchposition = new Vector2(0, 0);
        IsTouch = false;
        if (iseditor == true)
        {
            if (Input.GetMouseButtonDown(0) == true)
            {
                IsTouch = true;
                Touchbegan = true;
                Touchposition = Input.mousePosition;
                //Debug.Log("押した");
            }
            if (Input.GetMouseButton(0) == true)
            {
                IsTouch = true;
                Touchmoved = true;
                Touchposition = Input.mousePosition;
                //Debug.Log("押している");
            }
            if (Input.GetMouseButtonUp(0) == true)
            {
                IsTouch = true;
                Touchended = true;
                Touchposition = Input.mousePosition;
                //Debug.Log("離した");
            }
        }
        else
        {
            if (Input.touchCount > 0)
            {
                IsTouch = true;
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    Touchbegan = true;
                    Touchposition = Input.mousePosition;
                    //Debug.Log("押した");
                }
                if (touch.phase == TouchPhase.Moved)
                {
                    Touchmoved = true;
                    Touchposition = Input.mousePosition;
                    //Debug.Log("押している");
                }
                if (touch.phase == TouchPhase.Stationary)
                {
                    Touchmoved = true;
                    Touchposition = Input.mousePosition;
                    //Debug.Log("押している");
                }
                if (touch.phase == TouchPhase.Ended)
                {
                    Touchended = true;
                    Touchposition = Input.mousePosition;
                    //Debug.Log("離した");
                }
            }
        }
    }
}

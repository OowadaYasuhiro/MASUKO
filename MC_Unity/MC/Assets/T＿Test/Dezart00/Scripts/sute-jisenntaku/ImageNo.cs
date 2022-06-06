using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageNo : SpriteNo<Image>
{
    [SerializeField]
    private bool _raycastTarget = false;

    //=================================================================================
    //初期化
    //=================================================================================

    //新しく作ったImageの初期化
    protected override void InitComponent(Image image)
    {
        image.raycastTarget = _raycastTarget;
    }

    //=================================================================================
    //更新
    //=================================================================================

    //Spriteを更新
    protected override void UpdateComponent(Image image, Sprite sprite, Color color)
    {
        image.sprite = sprite;
        image.color = color;
        image.SetNativeSize();
    }

    //=================================================================================
    //設定変更
    //=================================================================================

    /// <summary>
    /// RaycastTargetの設定を変更する
    /// </summary>
    public void ChangeRaycastTarget(bool raycastTarget)
    {
        _raycastTarget = raycastTarget;
        InitComponents();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
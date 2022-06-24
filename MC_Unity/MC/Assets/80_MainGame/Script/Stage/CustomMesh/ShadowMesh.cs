using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMesh : MonoBehaviour
{
    //ステージ4隅
    readonly Vector2 downleft = new Vector2(-7.9f, -2f);
    readonly Vector2 upleft = new Vector2(-7.01f, 3.56f);
    readonly Vector2 downright = new Vector2(7.9f, -2f);
    readonly Vector2 upright = new Vector2(7.01f, 3.56f);

    //
    const float depth0 = 3.56f;
    const float depth1 = 2.727f;
    const float depth2 = 1.865f;
    const float depth3 = 0.9565f;
    const float depth4 = 0.015f;
    const float depth5 = -0.975f;
    const float depth6 = -2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

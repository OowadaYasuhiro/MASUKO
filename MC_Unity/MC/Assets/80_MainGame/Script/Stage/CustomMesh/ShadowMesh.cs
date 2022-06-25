using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMesh : MonoBehaviour
{

    MeshFilter meshFilter;
    Mesh mesh;

    //ステージ4隅
    readonly Vector2 downleft = new Vector2(-7.9f, -2f);
    readonly Vector2 upleft = new Vector2(-7.01f, 3.56f);
    readonly Vector2 downright = new Vector2(7.9f, -2f);
    readonly Vector2 upright = new Vector2(7.01f, 3.56f);

    //横線の高さ
    const float depth0 = 3.56f;
    const float depth1 = 2.727f;
    const float depth2 = 1.865f;
    const float depth3 = 0.9565f;
    const float depth4 = 0.015f;
    const float depth5 = -0.975f;
    const float depth6 = -2f;

    float[] depth = new float[] { -2f ,-0.975f , 0.015f , 0.9565f , 1.865f , 2.727f , 3.56f };

    //比率
    const float ratio = 0.16f;

    //頂点座標配列
    Vector3[] vertics = new Vector3[77];

    //三角形[x,y,value]
    int[,,] triangles = new int[10,6,6];

    //横の頂点の数
    const int horizontalVerticsSize = 11;
    //縦の頂点の数
    const int verticalVerticsSize = 7;

    //グリッドのサイズ
    const int height = 6;
    const int width = 10;

    // Start is called before the first frame update
    void Start()
    {

        meshFilter = gameObject.GetComponent<MeshFilter>();
        mesh = new Mesh();

        //三角形の形成
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                //左下
                triangles[i, j, 0] = horizontalVerticsSize * j + i;
                //左下の上
                triangles[i, j, 1] = triangles[i, j, 0] + horizontalVerticsSize;
                //左下の上+１
                triangles[i, j, 2] = triangles[i, j, 0] + 1;
                //上と同じ
                triangles[i, j, 3] = triangles[i, j, 2];
                //左下+１
                triangles[i, j, 4] = triangles[i, j, 0] + 1;

                triangles[i, j, 5] = triangles[i, j, 0];
            }
        }
        int number = 0;
        for (int i = 0; i < verticalVerticsSize; i++)
        {
            float horizontalLine = downright.x - downleft.x - ((ratio * depth[i] - depth[0]) * 2);
            float singleLine = horizontalLine / 10;
            for (int j = 0; j < horizontalVerticsSize; j++)
            {
                vertics[number] = new Vector3(-(horizontalLine/2) + singleLine * j,depth[i]);
                number++;
            }
        }

        mesh.SetVertices(vertics);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                int[] subtriangles = new int[6];
                for (int n = 0; n < 6; n++)
                {
                    subtriangles[n] = triangles[i,j,n];
                }
                mesh.SetTriangles(subtriangles, 0);
            }
        }

        meshFilter.mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

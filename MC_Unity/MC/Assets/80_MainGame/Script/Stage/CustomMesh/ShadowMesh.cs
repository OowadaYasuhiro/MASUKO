using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMesh : MonoBehaviour
{
    MeshFilter meshFilter;
    Mesh mesh;
    MeshRenderer meshRenderer;
    MainGame mainGame;

    //ステージ4隅
    readonly Vector2 downleft = new Vector2(-7.9f, -3.17f);
    readonly Vector2 upleft = new Vector2(-7.01f, 3.33f);
    readonly Vector2 downright = new Vector2(7.9f, -3.17f);
    readonly Vector2 upright = new Vector2(7.01f, 3.33f);

    //横線の高さ
    const float depth0 = 3.33f;
    const float depth1 = 2.35f;
    const float depth2 = 1.34f;
    const float depth3 = 0.28f;
    const float depth4 = -0.81f;
    const float depth5 = -1.97f;
    const float depth6 = -3.17f;

    float[] depth = new float[] { -3.17f, -1.97f, -0.81f, 0.28f, 1.34f, 2.35f, 3.33f };

    //比率
    const float ratio = 0.1369f;

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
        
    }

    public void Initialize()
    {
        mesh = new Mesh();

        mainGame = GameObject.Find("MainGame").GetComponent<MainGame>();
        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();

        //頂点の生成
        int number = 0;
        for (int i = 0; i < verticalVerticsSize; i++)
        {
            float horizontalLine = downright.x - downleft.x - ((ratio * (depth[i] - depth[0])) * 2);
            float singleLine = horizontalLine / 10;
            for (int j = 0; j < horizontalVerticsSize; j++)
            {
                vertics[number] = new Vector3(-(horizontalLine / 2) + (singleLine * j), depth[i]);
                number++;
            }
        }

        //頂点を設定
        mesh.SetVertices(vertics);

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
                triangles[i, j, 2] = triangles[i, j, 1] + 1;
                //上と同じ
                triangles[i, j, 3] = triangles[i, j, 2];
                //左下+１
                triangles[i, j, 4] = triangles[i, j, 0] + 1;
                //左下
                triangles[i, j, 5] = triangles[i, j, 0];
            }
        }

        //サブメッシュの上限設定
        mesh.subMeshCount = 60;

        //viewと影を付ける部分を合わせる
        int loopNumber = 0;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                int[] subtriangles = new int[6];
                for (int n = 0; n < 6; n++)
                {
                    subtriangles[n] = triangles[i, j, n];
                }
                //三角形設定
                mesh.SetTriangles(subtriangles, loopNumber);
                loopNumber++;
            }
        }

        //フィルターにメッシュを渡す
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        meshFilter.mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    //影の再設定
    public void SetMesh(bool[,] view)
    {
        int loopNumber = 0;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (view[i, j] == false)
                {
                    int[] subtriangles = new int[6];
                    for (int n = 0; n < 6; n++)
                    {
                        subtriangles[n] = triangles[i, j, n];
                    }
                    //三角形設定
                    mesh.SetTriangles(subtriangles, loopNumber);
                }
                loopNumber++;
            }
        }

        //フィルターにメッシュを渡す
        meshFilter.mesh = mesh;
    }
    */

    //マテリアル変更
    public void SetColor(bool[,] target,Material material)
    {
        Material[] mats = meshRenderer.materials;
        //左下から上に
        for (int i = 0; i < target.GetLength(0); i++)
        {
            for (int j = 0; j < target.GetLength(1); j++)
            {
                if (target[i,j] == true)
                {
                    mats[target.GetLength(1) * i + j] = material;
                }
            }
        }
        meshRenderer.materials = mats;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMeshTest : MonoBehaviour
{
    MeshFilter meshFilter;
    Mesh mesh;

    [SerializeField]
    Vector3[] anchor = new Vector3[4];

    //頂点
    Vector3[] vertics = new Vector3[4];

    //三角形
    int[] triangles = new int[6];

    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.GetComponent<MeshFilter>();
        mesh = new Mesh();

        vertics[0] = anchor[0];
        vertics[1] = anchor[1];
        vertics[2] = anchor[2];
        vertics[3] = anchor[3];

        mesh.SetVertices(vertics);

        triangles[0] = 0;
        triangles[1] = 2;
        triangles[2] = 1;
        triangles[3] = 2;
        triangles[4] = 3;
        triangles[5] = 1;

        mesh.SetTriangles(triangles, 0);

        meshFilter.mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

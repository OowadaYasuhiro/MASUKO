using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelGrid : MonoBehaviour
{
    [SerializeField]
    MeshFilter _meshFilter;
    Mesh _mesh;

    [SerializeField]
    Vector3 _anchorPosition;

    Vector3[] _vertics = new Vector3[43264];

    int[] _triangles = new int[64896];

    const int _maxValue = 10816;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Primitivas : MonoBehaviour
{

    public Material materialNice;
    // Start is called before the first frame update
    void Start()
    {
        createCubeNice();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void createCubeNice()
    {
        Vector3[] vertices = {

            new Vector3 (0,0,0), //0
            new Vector3 (1,0,0), //1
            new Vector3 (0,1,0), //2
            new Vector3 (1,1,0), //3
            new Vector3 (0,0,1), //4
            new Vector3 (1,0,1), //5
            new Vector3 (0,1,1), //6
            new Vector3 (1,1,1), //7
         
            

        };

        int[] triangle= {
            2,1,0, //cara frontal de una parte//b
            3,1,2,   //cara frontal segunda parte//b
            3,5,1,//b
            7,5,3,//b
            6,3,2,//b
            7,3,6,//b
            0,5,4, //b
            1,5,0,//b
            4,7,6,//b
            5,7,4,//b
            6,0,4,
            2,0,6

        };

        Vector2[] uvs = {
            
            
            new Vector2(0, 0.66f),
            new Vector2(0.25f, 0.66f),
            new Vector2(0, 0.33f),
            new Vector2(0.25f, 0.33f),

            new Vector2(0.5f, 0.66f),
            new Vector2(0.5f, 0.33f),
            new Vector2(0.75f, 0.66f),
            new Vector2(0.75f, 0.33f),

            /*new Vector2(1, 0.66f),
            new Vector2(1, 0.33f),

            new Vector2(0.25f, 1),
            new Vector2(0.5f, 1),

            new Vector2(0.25f, 0),
            new Vector2(0.5f, 0),*/


        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        this.GetComponent<MeshRenderer>().material=materialNice;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangle;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}

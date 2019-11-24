using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRectangDetect : MonoBehaviour
{
    public Transform attacked;
    GameObject go;      //生成矩形
    MeshFilter mf;
    MeshRenderer mr;
    Shader shader;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ToDrawRectangleSolid(transform, transform.localPosition, 4, 2);

            if (RectAttackJubge(transform, attacked, 4, 2f))
            {
                Debug.Log("攻击到");
            }
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            if (go != null)
            {
                Destroy(go);
            }
        }
    }

    /// <summary>
    /// 矩形攻击范围
    /// </summary>
    /// <param name="attacker">攻击方</param>
    /// <param name="attacked">被攻击方</param>
    /// <param name="forwardDistance">矩形前方的距离</param>
    /// <param name="rightDistance">矩形宽度/2</param>
    /// <returns></returns>
    public bool RectAttackJubge(Transform attacker, Transform attacked, float forwardDistance, float rightDistance)
    {
        Vector3 deltaA = attacked.position - attacker.position;

        float forwardDotA = Vector3.Dot(attacker.forward, deltaA);
        if (forwardDotA > 0 && forwardDotA <= forwardDistance)
        {
            if (Mathf.Abs(Vector3.Dot(attacker.right, deltaA)) < rightDistance)
            {
                return true;
            }
        }
        return false;
    }

    //制作网格
    private GameObject CreateMesh(List<Vector3> vertices)
    {
        int[] triangles;
        Mesh mesh = new Mesh();

        int triangleAmount = vertices.Count - 2;
        triangles = new int[3 * triangleAmount];

        for (int i = 0; i < triangleAmount; i++)
        {
            triangles[3 * 1] = 0;
            triangles[3 * i + 1] = i + 1;
            triangles[3 * i + 2] = i + 2;
        }

        if (go == null)
        {
            go = new GameObject("Rectang");
            go.transform.position = new Vector3(0, 0.1f, 0);
            mf = go.AddComponent<MeshFilter>();
            mr = go.AddComponent<MeshRenderer>();

            shader = Shader.Find("Unlit/Color");
        }

        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles;
        mf.mesh = mesh;
        mr.material.shader = shader;
        mr.material.color = Color.red;

        return go;
    }


    /// <summary>
    /// 绘制实心长方形
    /// </summary>
    /// <param name="t">矩形参考物</param>
    /// <param name="bottomMiddle">矩形的中心点</param>
    /// <param name="length">矩形长度</param>
    /// <param name="width">矩形宽度的一半</param>
    public void ToDrawRectangleSolid(Transform t, Vector3 bottomMiddle, float length, float width)
    {
        List<Vector3> vertices = new List<Vector3>();

        vertices.Add(bottomMiddle - t.right * width);
        vertices.Add(bottomMiddle - t.right * width + t.forward * length);
        vertices.Add(bottomMiddle + t.right * width + t.forward * length);
        vertices.Add(bottomMiddle + t.right * width);

        CreateMesh(vertices);
    }
 
}

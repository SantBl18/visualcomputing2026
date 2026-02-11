using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class text : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject tails = GameObject.Find("Tails");
        Debug.Log(tails);
        int totalVertices = 0;
        int triangleCount = 0;

        MeshFilter[] meshFilters = tails.GetComponentsInChildren<MeshFilter>();
        int currentSubMesh = 0;
        foreach (MeshFilter mf in meshFilters)
        {
            totalVertices += mf.mesh.vertexCount;
            triangleCount += mf.mesh.triangles.Length;
            currentSubMesh += 1;
        }

        print(totalVertices.ToString());
        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        string textString = $"Vertex count: {totalVertices}\n" +
            $"Triangle count: {triangleCount}\n" +
            $"Submesh count: {currentSubMesh}";
        text.SetText(textString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

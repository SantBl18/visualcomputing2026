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

        MeshFilter[] meshFilters = tails.GetComponentsInChildren<MeshFilter>();
        foreach (MeshFilter mf in meshFilters)
        {
            totalVertices += mf.mesh.vertexCount;
        }
        print(totalVertices.ToString());
        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        text.SetText(totalVertices.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

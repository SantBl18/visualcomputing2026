using UnityEngine;

public class render : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnPreRender()
    {
        GL.wireframe = true;
    }

    void OnPostRender()
    {

    }
}

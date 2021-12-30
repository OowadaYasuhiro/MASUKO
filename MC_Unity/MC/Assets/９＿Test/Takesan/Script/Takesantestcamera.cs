using UnityEngine;

[ExecuteInEditMode]
public class Takesantestcamera : MonoBehaviour
{
    new Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent <Camera>();
    }

    
    [ContextMenu("set169")] 
    public void set169(){
        camera.aspect = 1.833333f;
        Debug.Log(camera.aspect);
    }

    [ContextMenu("setpixel4a")]
    public void setpixel4a(){
        camera.aspect = 2.166666f;
        Debug.Log(camera.aspect);
    }
}

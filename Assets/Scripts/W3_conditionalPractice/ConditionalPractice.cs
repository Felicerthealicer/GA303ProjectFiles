using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public Color go2ElseColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ColorGameObjectByName();
        ColorGameObjectByTag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ColorGameObjectByName()
    {
        
        Debug.Log("go is named " + go.name);
        Debug.Log("go2 is named " + go2.name);

        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.name == "Cube")
        {

            //GetComponent will look for the component on the gameObject it is being called on.
            //If there is no component of the type you are trying to get, when you use the dot operator after it, it will throw a null referene exception.

            //go.GetComponent<MeshRenderer>().material.color = Color.magenta;

            //If we create a local variable in the fuction that does the GetComponent call once,
            //we can use this variable multiple times that refers to this object's specific MeshRenderer,
            //which is more efficient than calling GetComponent multiple times.

            goMeshRenderer.material.color = Color.magenta;

            //Change the color to pink aka magenta 
        }

        else if(go.name == "Sphere")
        {
            //go.GetComponent<MeshRenderer>().material.color = Color.cyan;

            goMeshRenderer.material.color = Color.cyan;

            //Change the color to cyan 
        }
        
        else if(go.name == "Cylinder")
        {

            goMeshRenderer.material.color = Color.black;

            //Change the color to black 
        }

        else
        {

            goMeshRenderer.material.color = new Color32(200, 100, 3, 255); 

            //Change the color to orange
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name == "Cube")
        {
            go2MeshRenderer.material.color = Color.gray;
        }

        else if (go2.name == "Sphere")
        {
            go2MeshRenderer.material.color = Color.white;
        }

        else if (go2.name == "Cylinder")
        {
            go2MeshRenderer.material.color = Color.red;
        }

        else
        {
            go2MeshRenderer.material.color = go2ElseColor;

            //Change the color to our custom color
        }
    }

    void ColorGameObjectByTag()
    {
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.tag == "CoolGuy")
        {
            goMeshRenderer.material.color = Color.magenta;

            //Change the color to pink aka magenta 
        }

        else if (go.tag == "NotCoolGuy")
        {
            //go.GetComponent<MeshRenderer>().material.color = Color.cyan;

            goMeshRenderer.material.color = Color.cyan;

            //Change the color to cyan 
        }

        else if (go.tag == "OkayGuy")
        {

            goMeshRenderer.material.color = Color.black;

            //Change the color to black 
        }

        else
        {

            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);

            //Change the color to orange
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.tag == "CoolGuy")
        {
            go2MeshRenderer.material.color = Color.gray;
        }

        else if (go2.tag == "NotCoolGuy")
        {
            go2MeshRenderer.material.color = Color.white;
        }

        else if (go2.tag == "OkayGuy")
        {
            go2MeshRenderer.material.color = Color.red;
        }

        else
        {
            go2MeshRenderer.material.color = go2ElseColor;

            //Change the color to our custom color
        }

    }

}

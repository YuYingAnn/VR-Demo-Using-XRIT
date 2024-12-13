using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.AI;

public class ChangeColor : MonoBehaviour
{
    public Material material_1;
    public Material material_2;

    public void SwitchColor()
    {
        var materialNow = GetComponent<Material>();

        if (materialNow.Equals(material_1))
        {
            GetComponent<MeshRenderer>().material = material_2;
        }
        else
        {
            GetComponent<MeshRenderer>().material = material_1;
        }
    }
    public void ChangeColorTo(Material color)
    {
        GetComponent<MeshRenderer>().material = color;
    }
}

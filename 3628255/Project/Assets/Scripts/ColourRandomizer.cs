using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColourRandomizer : MonoBehaviour
{
    public List<Material> colours;
    
    private void Start()
    {
        var r = GetComponent<Renderer>();
        r.sharedMaterial = RandomFromList(colours);
    }

    private static Material RandomFromList(List<Material> materials)
    {
        return materials[Random.Range(0, materials.Count)];
    }
}
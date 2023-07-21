using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    public bool isDissolving = false;
    float fade = 1f;

    public SpriteRenderer[] spriteRenderers;
    public Material[] materials;
    public Material materialPrefab;
    private void Start()
    {
        materials = new Material[spriteRenderers.Length];
        for (int i = 0; i < spriteRenderers.Length; i++)
        {
            materials[i] = Instantiate(materialPrefab);
            spriteRenderers[i].material = materials[i];
        }
    }

    private void Update()
    {
        Dissolving();
    }

    public void Dissolving()
    {
        if (isDissolving)
        {
            fade -= Time.deltaTime;

            if (fade <= 0)
            {
                fade = 0f;
                isDissolving = false;
            }

            foreach (Material material in materials)
            {
                material.SetFloat("_Fade", fade);
            }
        }
    }
}

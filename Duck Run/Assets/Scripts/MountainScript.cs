using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float speed = GameManager.Instance.gameSpeed / (transform.localScale.x * 4);
        meshRenderer.material.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }

}


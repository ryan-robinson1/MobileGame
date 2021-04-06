﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkDeleter : MonoBehaviour
{
    private GameObject chunkGenerator;
    private void Start()
    {
        chunkGenerator = GameObject.FindGameObjectWithTag("ChunkGenerator");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            chunkGenerator.GetComponent<ChunkGenerator>().degenerateChunk();
        }
    }
}

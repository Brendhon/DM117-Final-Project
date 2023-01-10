using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    // Attributes
    public GameObject[] section;
    public int zPos = 100;
    public bool creatingSection = false;
    public int secNum;

    // Update is called once per frame
    void Update()
    {
        if(creatingSection == false)
        {
            //Update value of creatingSection
            creatingSection = true;

            // Create routine to generate a new section
            StartCoroutine(GeneratesSection());
        }
    }

    private IEnumerator GeneratesSection()
    {
        // Generate a number between 0 to 2
        secNum = UnityEngine.Random.Range(0, 3);

        // Instanciate a new sector
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);

        // Update Z Position
        zPos += 100;

        // Wait 2 seconds to create another section
        yield return new WaitForSeconds(7);

        // Set creating to false
        creatingSection = false;
    }
}

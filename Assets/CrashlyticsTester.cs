using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CrashlyticsTester : MonoBehaviour
{
    int updatesBeforeException;
    // Start is called before the first frame update
    void Start()
    {
        updatesBeforeException = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Call the exception-throwing method here so that it's run
        // every frame update
        throwExceptionEvery60Updates();
    }

    void throwExceptionEvery60Updates()
    {
        if (updatesBeforeException > 0)
        {
            updatesBeforeException--;
        }
        else
        {
            // Set the counter to 60 updates
            updatesBeforeException = 60;

            // Throw an exception to test your Crashlytics implementation
            throw new System.Exception("test exception please ignore");
        }
    }
}

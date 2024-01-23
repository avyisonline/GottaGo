using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCursor : MonoBehaviour
{
    private bool gay;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        gay = true;
    }
}

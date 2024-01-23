using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{
    private bool yippee;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        yippee = true;
    }
}

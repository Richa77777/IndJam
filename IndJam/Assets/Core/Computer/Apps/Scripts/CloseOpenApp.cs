using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOpenApp : MonoBehaviour
{
    public void OpenApp(GameObject app)
    {
        app.SetActive(true);
    }

    public void CloseApp(GameObject app)
    {
        app.SetActive(false);
    }
}

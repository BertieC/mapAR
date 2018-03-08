using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigateScript : MonoBehaviour {
    public void Navigate(string location) {
        Application.OpenURL(location);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

	public void ExitGame()
    {
        Debug.Log("User has quit the game.");
        //#if UNITY_EDITOR
            //UnityEditor.EditorApplication.isPlaying = false;
        //#else
		    Application.Quit();
        //#endif

    }
}

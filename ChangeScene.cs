using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
	public void GoToScene(string sceneName){
		Debug.Log ("Method Called");
		SceneManager.LoadScene (sceneName);
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    public string sceneToLoad;
    private GameObject player;
    private GameObject collectibles;
    private GameObject floor;
    private GameObject counter;
    private GameObject music;

    private void Start()
    {
        player = GameObject.Find("playerSystem");
        collectibles = GameObject.Find("collectibles");
        floor = GameObject.Find("floorCollider");
        music = GameObject.Find("audio");
        DontDestroyOnLoad(player);
        DontDestroyOnLoad(collectibles);
        DontDestroyOnLoad(floor);
        DontDestroyOnLoad(music);


    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Single);
        }
    }
}

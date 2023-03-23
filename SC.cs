using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC : MonoBehaviour
{

    public float dur = 5f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(Wait_for_Vedio());
    }

    IEnumerator Wait_for_Vedio()
    {
        yield return new WaitForSeconds(dur);
        SceneManager.LoadScene(2);
    }
}

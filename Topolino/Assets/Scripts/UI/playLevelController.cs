using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playLevelController : MonoBehaviour
{
    public void PlayLevel(int _idx)
    {
        Time.timeScale = 1;
        GameManager.manager.LoadScene(_idx);
    }
}

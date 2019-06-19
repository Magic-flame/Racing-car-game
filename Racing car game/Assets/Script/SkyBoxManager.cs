using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxManager : SingletonMonoBehaviour<SkyBoxManager> {
    public List<Material> SkyBoxes;
    public int nowIndex = 0;
    // Use this for initialization
    public void SetSkyBox()
    {
        nowIndex = UnityEngine.Random.Range(0, 17);
        RenderSettings.skybox = SkyBoxes[nowIndex];
    }
}

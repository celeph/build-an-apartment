using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovie : MonoBehaviour {

    public Object[] frames;
    public float changeInterval = 0.33F;
    public Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        frames = Resources.LoadAll("movie", typeof(Texture2D));
    }

    // Update is called once per frame
    void Update()
    {
        if (frames.Length == 0) return;

        int index = Mathf.FloorToInt(Time.time / changeInterval);
        index = index % frames.Length;

        rend.material.mainTexture = (Texture2D)frames[index];
    }
}

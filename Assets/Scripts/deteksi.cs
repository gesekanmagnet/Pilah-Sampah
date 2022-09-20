using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deteksi : MonoBehaviour {

	public string nameTag;
	public AudioClip benar;
	public AudioClip salah;
		private AudioSource mediaPlayerBenar;
		private AudioSource mediaPlayerSalah;
		public Text textScore;

	// Use this for initialization
	void Start () {
		mediaPlayerBenar = gameObject.AddComponent<AudioSource>();
		mediaPlayerBenar.clip = benar;
		mediaPlayerSalah = gameObject.AddComponent<AudioSource>();
		mediaPlayerSalah.clip = salah;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag.Equals(nameTag))
		{
			Data.score += 25;
			textScore.text = Data.score.ToString();
			Destroy(other.gameObject);
			mediaPlayerBenar.Play();
		}
		else
		{
			Data.score -= 5;
			textScore.text = Data.score.ToString();
			Destroy(other.gameObject);
			mediaPlayerSalah.Play();
		}
	}
}

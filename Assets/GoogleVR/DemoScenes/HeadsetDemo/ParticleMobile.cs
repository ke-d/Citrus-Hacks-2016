using UnityEngine;
using System.Collections;

public class ParticleMobile : MonoBehaviour {
	private ParticleSystem ps;
	// Use this for initialization
	void Start () {
		ps = GetComponent<ParticleSystem> ();
		#if UNITY_IOS || UNITY_ANDROID
		ps.maxParticles = 7;
		#else 
		ps.maxParticles = 20;
		#endif
	}
	

}

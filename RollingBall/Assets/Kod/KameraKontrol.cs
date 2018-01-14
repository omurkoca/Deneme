using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour {

    public GameObject top;
    Vector3 aradakiMesafe;
	void Start ()
    {
        //transform.position kameranın içinde kod yazdığımız için kameranın pozisyonuna ulaşabiliyoruz, Fakat topun pozisyonuna ulaşamıyoruz
        //top.transform.position GameObject oluşturduk ve unityde topu ona atadık. Böylece erişebiliyoruz.
        aradakiMesafe = transform.position - top.transform.position;
        //Oyunun başında bir kere mesafeyi bulduruyoruz ve her yerinde kullanıyoruz.
	}
	
	
	void LateUpdate () //Bütün updateler bitince çalışıyor
    {
        // transform.position = top.transform.position; kamera topun içine girer
        transform.position = top.transform.position + aradakiMesafe;
	}
}

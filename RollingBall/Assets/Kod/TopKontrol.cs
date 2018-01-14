using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour {
    Rigidbody fizik;
    public int hiz;
    int sayac = 0;
    public int ToplanacakObjeSayisi;
    public Text txtSayac;
    public Text txtOyunBitti;
    void Start ()
    {
        fizik = GetComponent<Rigidbody>();//Componente erişme	
	}
	
	void FixedUpdate ()
    {
        //Sürekli çalışır fakat sabit bir hızda sürekli.

        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        //Debug.Log("yatay = " +yatay+ "    dikey = "+dikey);


        Vector3 vec = new Vector3(yatay, 0, dikey);//3 boyutlu objelerin x, y, z koordinatlarında hareketini sağlıyor.
        fizik.AddForce(vec * hiz);//AddForce vector3 deki değerleri atayabiliyoruz.

	}

    void OnTriggerEnter(Collider other)//Enter Stay ve Exit metodları var
    {
        //Enter temas halinde çalışıyor
        //Stay Temas olduğu süre boyunca bize değer dönüyor.
        //--Kullanıcı yakalandığı zaman bununla ayarlayacaz
        //Exit Temastan çıkınca yazdırıyor
        //Destroy(other.gameObject);//Temas edilen objeyi yok et diyoruz
        //Böyle olursaa triggeri açık olan her gameObject yok olur.
        if (other.tag == "Engel")
        {
            Destroy(other.gameObject);
            //other.gameObject.SetActive(false); //Görünürlüğünü kaldırıyorsun, Enable False ve Visible False gibi düşün
            sayac++;

            txtSayac.text = "Sayac = " + sayac;

            if (sayac == ToplanacakObjeSayisi)
            {
                txtOyunBitti.text = "Oyun Bitti.";
            }
        }
    }

}

using UnityEngine;

public class Task0 : MonoBehaviour
{
    /*
     ----- TASK 0 ----------
     *
      sizden Assets/task0 videosunundaki kuralları izleyen bir proje hazırlamanızı istiyoruz.
      
      Fare sol tuşuna basıldığında  farenin oldugu noktada bir yuvarlak oluşur
      
      Yuvarlak fare ile birlikte hareket etmeli ve zamanla büyümelidir 
      
      Kontrol edilen yuvarlak başka bir yuvarlak ile temas ediyorsa kırmızı etmiyorsa
      yeşil renkte olmalıdır
      
      Fare tuşu bırakıldığında yuvarlak başka bir yuvarlakla temas etmiyorsa sahnede kalmaya devam eder
      ediyorsa yok olur.
     
     * TaskUtils içerisinde bulunan input ve draw fonksyonlarını kullanabilirsiniz.
     
     * Çözümünüzüm tamamını bu scriptin içerisine yazmalisiniz.
     
     *(!) Unity Physic kutuphanesinden yararlanmamalisiniz,
     *(!) Vector2,Vector3,Mathf,System.Collections dışında olabildiğince az disaridan kod kullanmaya calisin
     *(!) TasUtils teki cizim fonksyonlari task icin yeterlidir
     
     * 2 Taskı da bitirdikten sonra unity üst menüsünden Dalak/ExportSolution tuşuna basin, 
        oluşan Assets/MySolution dosyasını info@dalakgames.com adresine cv niz ile birlikte mail olarak gonderin
     
     */
    
    
    void Update()
    {
        Vector2 inputPos = TaskUtils.MouseWorldPos();
        TaskUtils.DrawCircle(inputPos,0.5f,Color.green);
    }
   
   
}

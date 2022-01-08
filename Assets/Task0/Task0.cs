using System.Collections.Generic;
using UnityEngine;

public class Task0 : MonoBehaviour
{
    /*
     ----- TASK 0 ----------
     * sizden Assets/task0 videosunundaki kuralları izleyen bir proje hazırlamanızı istiyoruz.
     * TaskUtils içerisinde bulunan input ve draw fonksyonlarını kullanabilirsiniz.
     * Çözümünüzüm tamamını bu scriptin içerisine yazmalisiniz.
     * Vector2,Vector3,Mathf,System.Collections dışında olabildiğince az disaridan kod kullanmaya calisin
     
     * 2 Taskı da bitirdikten sonra unity üst menüsünden Dalak/ExportSolution tuşuna basin, 
        oluşan Assets/MySolution dosyasını info@dalakgames.com adresine cv niz ile birlikte mail olarak gonderin
     
     */
    
    
    void Update()
    {
        Vector2 inputPos = TaskUtils.MouseWorldPos();
        TaskUtils.DrawCircle(inputPos,0.5f,Color.green);
    }
   
   
}

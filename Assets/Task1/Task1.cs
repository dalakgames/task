using UnityEngine;

public class Task1 : MonoBehaviour
{
    
    /*
     ----- TASK 1 ----------
     * sizden Assets/task1 videosunundaki kuralları izleyen bir proje hazırlamanızı istiyoruz.
     * TaskUtils içerisinde bulunan input ve draw fonksyonlarını kullanabilirsiniz.
     * Çözümünüzüm tamamını bu scriptin içerisine yazmalisiniz.
     * Vector2,Vector3,Mathf,System.Collections dışında olabildiğince az disaridan kod kullanmaya calisin
     
     * 2 Taskı da bitirdikten sonra unity üst menüsünden Dalak/ExportSolution tuşuna basin, 
        oluşan Assets/MySolution dosyasını info@dalakgames.com adresine cv niz ile birlikte mail olarak gonderin
     
     */
    
    
    Vector2 startPos;
    Vector2 endPos;
    
    const float lineWidth = 0.1f;
    const float circleRadius = 0.2f;
    
    void Update()
    {
        if (TaskUtils.IsMouseButtonDownThisFrame())
        {
            startPos = TaskUtils.MouseWorldPos();
        }

        if (TaskUtils.IsMouseButtonDown())
        {
            endPos = TaskUtils.MouseWorldPos();
        }

        TaskUtils.DrawLine(startPos,endPos, lineWidth,Color.white);
    }
}

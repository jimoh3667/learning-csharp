using System.Collections;

namespace LearningConsole.ClassFolders
{
    public class GenericClasses
    {

        public void ShowCollectionDiff()
        {
  
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Bode");
            arrayList.Add(false);


            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            List<string> list = new List<string>();
              list.Add("ade");
            list.Add("Toba");
               
            list.ForEach(item => Console.WriteLine(item));
           

        }
    }
}

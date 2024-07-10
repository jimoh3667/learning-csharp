namespace LearningConsole.ClassFolders
{
    public static class LearningArray
    {
        public static void ShowHowArraysWork()
        {
            string[] ridwanArray = new string[2];
            int [] tolu = { 1, 2, 4 };

            ridwanArray[0] = "1";
            ridwanArray[1] = "2";


            foreach (var ridwan in ridwanArray)
            {
                Console.WriteLine(ridwan);
            }

        }
    }
}

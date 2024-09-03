namespace labirintus0903
{
    internal class LabSim
    {
        private List<string> adatsorok;
        private char[,] lab;

        public void AdatsorokBeolvasasa(string forras)
        {
            using StreamReader sr = new(forras);
            while (!sr.EndOfStream) adatsorok.Add(sr.ReadLine());
        }
        public LabSim(string fileName)
        {
            AdatsorokBeolvasasa(@$"..\..\..\src\{fileName}");

        }
    }
}

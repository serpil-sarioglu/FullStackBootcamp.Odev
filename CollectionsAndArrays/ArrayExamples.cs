namespace CollectionsAndArrays
{
    internal class ArrayExamples
    {      
        public void ExamplesWithArray()
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            var cities = new string[3];
            cities[0] = "Adana";
            cities[1] = "Adıyaman";
            cities[2] = "Afyonkarahisar";

            var objects = new object[3];
            objects[0] = 1;
            objects[1] = "Merhaba";
            objects[2] = true;

            var numbers2 = new[] { 1, 2, 3, 4, 5 };
            var cities2 = new[] { "Düzce", "Osmaniye" };
            var objects2 = new object[] { 1, "Merhaba", true };
            var matrix = new int[2, 3] { { 1,2,3 }, { 3,5,7} };

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }
    }
}

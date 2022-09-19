namespace ExtensionMethods
{
    /// <summary>
    /// Extending ILists by a Shuffle ability.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Random number generator for shuffling.
        /// </summary>
        private static Random rng = new Random();

        /// <summary>
        /// Extension method for IList shuffling.
        /// </summary>
        /// <typeparam name="T">Generic extension for all types of objects.</typeparam>
        /// <param name="list">List to add functionality to.</param>
        public static void Shuffle<T>(this IList<T> list)
        {
            // this code was taken from https://stackoverflow.com/questions/273313/randomize-a-listt
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
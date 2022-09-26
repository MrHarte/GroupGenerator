namespace GroupGenerator
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Helper class for GroupsForm.
    /// </summary>
    internal static class GroupsFormHelpers
    {
        /// <summary>
        /// Reads number from textBox and returns it.
        /// </summary>
        /// <remarks>
        /// Displays an error message in a MessageBox and returns 0 if invalid number was read.
        /// </remarks>
        /// <param name="textBox">textBox to read number from.</param>
        /// <returns>entered integer, 0 if error.</returns>
        public static int GetNumberFrom(TextBox textBox)
        {
            int number;
            try
            {
                number = int.Parse(textBox.Text);
                if (number <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(textBox));
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Please enter valid numbers only!");
                number = 0;
            }

            return number;
        }

        /// <summary>
        /// Splits the given collection of people into numberOfGroups groups with a max size of maxSizeOfGroups.
        /// </summary>
        /// <param name="people">List of people to be split into groups.</param>
        /// <param name="numberOfGroups">Number of groups to be created.</param>
        /// <param name="maxGroupSize">Maximum size of groups.</param>
        /// <returns>Person Array containing the groups.</returns>
        /// <exception cref="ArgumentException">If the numberOfGroups or maxGroupSize do not make sense.</exception>
        public static Student[,] SplitIntoGroups(Collection<Student> people, int numberOfGroups, int maxGroupSize)
        {
            if (numberOfGroups <= 0 && maxGroupSize <= 0)
            {
                throw new ArgumentException("Negative list size not possible!");
            }

            if (numberOfGroups * maxGroupSize < people.Count)
            {
                MessageBox.Show("Lists not long enough for people collection!");
            }

            Student[,] groups = new Student[numberOfGroups, maxGroupSize];

            // Go through people in group
            for (int personNr = 0; personNr < maxGroupSize; personNr++)
            {
                // Go through groups
                for (int groupNr = 0; groupNr < numberOfGroups; groupNr++)
                {
                    if (groupNr + (personNr * numberOfGroups) < people.Count)
                    {
                        groups[groupNr, personNr] = people[groupNr + (personNr * numberOfGroups)];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return groups;
        }
    }
}
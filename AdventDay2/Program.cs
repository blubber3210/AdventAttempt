namespace AdventDay2
{
    internal class Program
    {
        public static long sum;
        static void Main(string[] args)
        {
            string input =
                "92916254-92945956,5454498003-5454580069,28-45,4615-7998,4747396917-4747534264,272993-389376,36290651-36423050,177-310,3246326-3418616,48-93,894714-949755,952007-1003147,3-16,632-1029,420-581,585519115-585673174,1041-1698,27443-39304,71589003-71823870,97-142,2790995-2837912,579556301-579617006,653443-674678,1515120817-1515176202,13504-20701,1896-3566,8359-13220,51924-98061,505196-638209,67070129-67263432,694648-751703,8892865662-8892912125";
            
            string[] eachRange = input.Split(',', StringSplitOptions.None);
            List<IdRange> allRanges = new List<IdRange>();

            foreach (string range in eachRange)
            {
                string[] parts = range.Split('-');
                long fromID = long.Parse(parts[0]);
                long toID = long.Parse(parts[1]);
                allRanges.Add(new IdRange(fromID, toID));
            }

            foreach (IdRange range in allRanges)
            {
                long a = range.From;
                long b = range.To;

                AddSum(a, b);
            }

            Console.WriteLine(sum);

        }

        public static void AddSum(long a, long b)
        {
            
            for (var i = a; i < b; i++)
            {
                string number = Convert.ToString(i);
                int mid = number.Length / 2;
                string firstHalf = number.Substring(0, mid);
                string secondHalf = number.Substring(mid);

                if (firstHalf == secondHalf) sum += i;

            }

        }
    }
}

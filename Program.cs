namespace LeetCode_2086
{
    public class Solution
    {
        //Declare our methods along with our parameters
        public int MinBuckets(string hamsters)
        {
            //Created two interger arrays along with defining the length
            int n = hamsters.Length;
            int[] leftHamster = new int[n];
            int[] rightHamster = new int[n];

            //iterate through the left string hamsters from left to right
            int lastHamster = -1;
            for (int i = 0; i < n; i++)
            {
                if (hamsters[i] == 'H')
                    lastHamster = i;
                leftHamster[i] = lastHamster;
            }

            //iterate through the right string hamsters from right to left
            lastHamster = n;
            for (int i = n - 1; i >= 0; i--)
            {
                if (hamsters[i] == 'H')
                    lastHamster = i;
                rightHamster[i] = lastHamster;
            }

            //Calculate minimum distance
            int minBuckets = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (hamsters[i] == '.')
                {
                    int minDist = Math.Min(i - leftHamster[i], rightHamster[i] - i);
                    minBuckets = Math.Min(minBuckets, minDist);
                }
            }

            return minBuckets == int.MaxValue ? -1 : minBuckets;
        }
    }
}


using System;

class Program
{
    static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int area = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    static void Main()
    {
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int result = MaxArea(height);
        Console.WriteLine("Output: " + result);
    }
}
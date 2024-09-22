namespace CyclicRotation;

public static class Rotator
{
    public static int[] Rotate(int[] input, int times)
    {
        if (input.Length == 0)
        {
            return input;
        }
        
        var actualTimes = times % input.Length;
        
        var maxIndex = input.Length - 1;
        
        var result = new int[input.Length];

        for (var i = 0; i < input.Length; i++)
        {
            var elem = input[i];

            var resultIndex = i + actualTimes ;
            if (resultIndex > maxIndex)
            {
                var extra = resultIndex - maxIndex;
                resultIndex = extra - 1;
            }

            result[resultIndex] = elem;
        }

        return result;
    }
}
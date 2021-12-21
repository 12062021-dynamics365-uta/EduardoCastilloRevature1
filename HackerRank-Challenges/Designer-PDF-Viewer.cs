//Designer PDF Viewer solution https://www.hackerrank.com/challenges/designer-pdf-viewer/submissions/code/248096085

static int designerPdfViewer(List<int> h, string word)
{
    char[] alphabet = new char[] { 'a', 'b', 'b', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    int[] heights = new int[h.Count];//array for save all word's letters heights
    char[] wordArray = word.ToCharArray();//array version of word

    //loop for find word's letters heights
    for (int i = 0; i < wordArray.Count(); i++)
    {
        for (int j = 0; j < alphabet.Count(); j++)
        {
            if (alphabet[j] == wordArray[i])
            {
                heights[i] = h[j];
                break;
            }
        }
    }

    int tallest = heights.Max();
    return tallest * word.Count();
}


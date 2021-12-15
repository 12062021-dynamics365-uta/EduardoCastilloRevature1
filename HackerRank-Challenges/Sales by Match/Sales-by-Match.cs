//Sales by Match Solution https://www.hackerrank.com/challenges/sock-merchant/submissions/code/247158486

static int sockMerchant(int n, List<int> ar)
{
       int count = 0;
       for(int i=0; i<= n; i++)
       {
           for(int j=i+1; j< n; j++)
           {
               if(ar[i]==ar[j] && ar[i] != -1)
               {
                   count++;
                   ar[j]= ar[i] = -1;
                   break;
               }              
           }
       }
       return count;
}

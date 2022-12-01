

/*int FaindMaxNum(int num)
{
    int max = 0;
    for (int i = num; i > 0; i++)
    {
        int n = i % 10;
        if (n > max) 
            max = n;
        i = i/10;
    }

    return max;

}*/

int num = 437;
int max = 0;
int n = 0; 

while (num>0){
    n = num % 10;
    if (n > max)
        max = n;
    num = num / 10;
}

Console.Write(max);
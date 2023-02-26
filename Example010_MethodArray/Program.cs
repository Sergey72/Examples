int[] array = { 1, 45, 23, 8, 62, 39, 11, 33, 82,100 };

int n = array.Length;
int find = 45;

int index = 0;
while (index < n)
{
  if(array[index] == find)
  {
    Console.WriteLine(index);
  }
  //index = index + 1;
  index++;
}
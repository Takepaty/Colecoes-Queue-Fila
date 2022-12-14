//Queue é uma biblioteca (fila)
//Dequeue remover fila

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);

Console.WriteLine("Adicionando item na fila.");

foreach (int item in fila)
{
  Console.WriteLine($"Item  {item}.");
}
Console.WriteLine();
Console.WriteLine($"Removendo item {fila.Dequeue()}.");

foreach (int item in fila)
{
  Console.WriteLine($"item {item}.");
}


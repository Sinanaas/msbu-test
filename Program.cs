// 4 2
// 8 9 3 2
// 5 4 1 3

// = 6

// 4 orang
// power awal = 2

// 8 9 3 2
// 5 4 1 3

// round 1:
// 2 -> dapet 3 : juned = 2 + 3 = 5

// 8 9 3
// 5 4 1

// round 2:
// 3 -> dapet 1 : juned  = 5 + 1 = 6
//
//

List<int> n = Console.ReadLine().Split().Select(int.Parse).ToList();
// Console.WriteLine(n[0]);
// Console.WriteLine(n[1]);

int currentPower = n[1];

int[,] matrix = new int[2, 2];

string powerLine = Console.ReadLine();
string[] powerParts = powerLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

string prizeLine = Console.ReadLine();
string[] prizeParts = prizeLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < n[0]; i++)
{
    if (currentPower >= int.Parse(powerParts[i]))
    {
        currentPower += int.Parse(prizeParts[i]);
        i = 0;
        n[0]--;
    }
}

Console.WriteLine(currentPower);

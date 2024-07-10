//--------------------------------------------------------------------------------------
                                 //Tic-Tac-Toe Checker
//--------------------------------------------------------------------------------------

namespace codewars.Exercises;

//i tried, its not working at the moment




int[,] board = { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
int rowsum = 0;
int colsum = 0;

for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 3; j++)
	{
		rowsum += board[i, j];
	}
	Console.WriteLine(rowsum);
	rowsum = 0; 
	Console.WriteLine();
}

Console.WriteLine();


for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 9; j++)
	{
		if (j % 3 == 0)
		{
			colsum += board[i, j / 3];
		}
	}

	Console.WriteLine(colsum);
	colsum = 0;
	Console.WriteLine();
}

Console.WriteLine();


int diagsum = 0;
for (int i = 0; i < 3; i++)
{
	diagsum += board[i, i];
}

Console.WriteLine(diagsum);
diagsum = 0;

for (int i = 3 - 1; i >= 0; i--)
{
	diagsum += board[i, i];
}

Console.WriteLine(diagsum);
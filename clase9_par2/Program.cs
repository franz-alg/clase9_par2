int[,] tablero = new int[5, 5];

void paso1_crear_tablero()
{
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            tablero[f, c] = 0;
        }
    }
}

void paso2_colocar_barcos()
{
    tablero[4, 3] = 1;
    tablero[1, 1] = 1;
    tablero[2, 1] = 1;
    tablero[3, 4] = 1;
}

void paso3_imprimir_tablero()
{
    string caracter_a_ímprimir = "";
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            switch (tablero[f, c])
            {
                case 0:
                    caracter_a_ímprimir = "-";
                    break;
                case 1:
                    caracter_a_ímprimir = "B";
                    break;
                case -1:
                    caracter_a_ímprimir = "*";
                    break;
                case -2:
                    caracter_a_ímprimir = "X";
                    break;
                default:
                    caracter_a_ímprimir = "-";
                    break;
            }
            Console.Write(caracter_a_ímprimir + " ");

        }
        Console.WriteLine();
    }
}

void paso4_ingreso_coordenadas()
{
    int fila, columna = 0;
    Console.Clear();
    do
    {
        Console.Write("ingresa la fila: ");
        fila = Convert.ToInt32(Console.ReadLine());
        Console.Write("ingresa la Columna: ");
        columna = Convert.ToInt32(Console.ReadLine());

        if (tablero[fila, columna] == 1)
        {
            Console.Beep();
            tablero[fila, columna] = -1;
        }
        else
        {
            tablero[fila, columna] = -2;
        }

        Console.Clear();
        paso3_imprimir_tablero();

    } while (true);
}



paso1_crear_tablero();
paso2_colocar_barcos();
paso3_imprimir_tablero();
paso4_ingreso_coordenadas();
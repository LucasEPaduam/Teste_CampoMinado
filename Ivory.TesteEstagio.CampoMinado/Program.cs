using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            int linha = 0;
            int coluna = 0;
            

            while (campoMinado.JogoStatus == 0)
            {
                for (int i = 1; i < campoMinado.Tabuleiro.Length - 1; i++)
                {


                    if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8)
                    {
                        linha = 1;
                    }
                    else if (i == 11 || i == 12 || i == 13 || i == 14 || i == 15 || i == 16 || i == 17 || i == 18 || i == 19)
                    {
                        linha = 2;
                    }
                    else if (i == 22 || i == 23 || i == 24 || i == 25 || i == 26 || i == 27 || i == 28 || i == 29 || i == 30)
                    {
                        linha = 3;
                    }
                    else if (i == 33 || i == 34 || i == 35 || i == 36 || i == 37 || i == 38 || i == 39 || i == 40 || i == 41)
                    {
                        linha = 4;
                    }
                    else if (i == 44 || i == 45 || i == 46 || i == 47 || i == 48 || i == 49 || i == 50 || i == 51 || i == 52)
                    {
                        linha = 5;
                    }
                    else if (i == 55 || i == 56 || i == 57 || i == 58 || i == 59 || i == 60 || i == 61 || i == 62 || i == 63)
                    {
                        linha = 6;
                    }
                    else if (i == 66 || i == 67 || i == 68 || i == 69 || i == 70 || i == 71 || i == 72 || i == 73 || i == 74)
                    {
                        linha = 7;
                    }
                    else if (i == 77 || i == 78 || i == 79 || i == 80 || i == 81 || i == 82 || i == 83 || i == 84 || i == 85)
                    {
                        linha = 8;
                    }
                    else if (i == 88 || i == 89 || i == 90 || i == 91 || i == 92 || i == 93 || i == 94 || i == 95 || i == 96)
                    {
                        linha = 9;
                    }


                    if (i == 0 || i == 11 || i == 22 || i == 33 || i == 44 || i == 55 || i == 66 || i == 77 || i == 88)
                    {
                        coluna = 1;
                    }
                    else if (i == 1 || i == 12 || i == 23 || i == 34 || i == 45 || i == 56 || i == 67 || i == 78 || i == 89)
                    {
                        coluna = 2;
                    }
                    else if (i == 2 || i == 13 || i == 24 || i == 35 || i == 46 || i == 57 || i == 68 || i == 79 || i == 90)
                    {
                        coluna = 3;
                    }
                    else if (i == 3 || i == 14 || i == 25 || i == 36 || i == 47 || i == 58 || i == 69 || i == 80 || i == 91)
                    {
                        coluna = 4;
                    }
                    else if (i == 4 || i == 15 || i == 26 || i == 37 || i == 48 || i == 59 || i == 70 || i == 81 || i == 92)
                    {
                        coluna = 5;
                    }
                    else if (i == 5 || i == 16 || i == 27 || i == 38 || i == 49 || i == 60 || i == 71 || i == 82 || i == 93)
                    {
                        coluna = 6;
                    }
                    else if (i == 6 || i == 17 || i == 28 || i == 39 || i == 50 || i == 61 || i == 72 || i == 83 || i == 94)
                    {
                        coluna = 7;
                    }
                    else if (i == 7 || i == 18 || i == 29 || i == 40 || i == 51 || i == 62 || i == 73 || i == 84 || i == 95)
                    {
                        coluna = 8;
                    }
                    else if (i == 8 || i == 19 || i == 30 || i == 41 || i == 52 || i == 63 || i == 74 || i == 85 || i == 96)
                    {
                        coluna = 9;
                    }

                     if (campoMinado.Tabuleiro[i].ToString().Contains("3"))
                     {
                        campoMinado.Abrir(linha + 1, coluna - 1);
                        
                    }
                     else if (campoMinado.Tabuleiro[i].ToString().Contains("-") && campoMinado.Tabuleiro[i - 1].ToString().Contains("0"))
                     {
                        campoMinado.Abrir(linha, coluna);
                    }
                     else if (campoMinado.Tabuleiro[i].ToString().Contains("-") && campoMinado.Tabuleiro[i + 1].ToString().Contains("1"))
                     {
                        campoMinado.Abrir(linha, coluna);
                    }
                    else if (campoMinado.Tabuleiro[i].ToString().Contains("-") && campoMinado.Tabuleiro[i + 1].ToString().Contains("3"))
                    {
                        campoMinado.Abrir(linha, coluna - 2);
                    }
                    else if (campoMinado.Tabuleiro[i].ToString().Contains("-") && campoMinado.Tabuleiro[i + 1].ToString().Contains("2"))
                    {
                        campoMinado.Abrir(linha, coluna - 1);
                    }
                    else if (campoMinado.Tabuleiro[i].ToString().Contains("1") && campoMinado.Tabuleiro[i + 1].ToString().Contains("0"))
                    {
                        campoMinado.Abrir(linha + 1, coluna);
                    }
                    else if (campoMinado.Tabuleiro[i].ToString().Contains("4"))
                    {
                        campoMinado.Abrir(linha + 1, coluna +1);
                    }
                    else if (campoMinado.Tabuleiro[i].ToString().Contains("2") && campoMinado.Tabuleiro[i + 1].ToString().Contains("-"))
                    {
                        campoMinado.Abrir(linha - 1, coluna + 1);
                    }
                    

                    Console.WriteLine(campoMinado.Tabuleiro);
                }
                
            }


            if (campoMinado.JogoStatus == 1)
            {
                Console.Clear();
                          
                Console.WriteLine(campoMinado.Tabuleiro);
                Console.WriteLine("\n\nVOCÊ VENCEU!!!");
            }
            else if(campoMinado.JogoStatus == 2)
            {
                Console.Clear();
                
                Console.WriteLine(campoMinado.Tabuleiro);
                Console.WriteLine("\n\nVOCÊ PERDEU!!!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(campoMinado.Tabuleiro);
            }

           

        }
        
    }
}
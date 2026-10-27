using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;

public class CodeQuest
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        const string MenuTitle = "\n===== MAIN MENU - CODEQUEST =====\n";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string ErrorNotNumber = "Error: you must type a number, not text.";
        const string ErrorTooBig = "Error: that number is too big.";
        const string ErrorRange = "Error: the option must be between 0 and 3.";
        const string ErrorNoInput = "Error: no input received.";



        const string LINE = "\n---------------------------------\n";
        const string WELCOME = "¡Welcome to the Arcanist Academy!";
        string nameMage;


        int option = -1;
        bool isValid;

        do
        {
            isValid = false; // A cada volta suposem que l'entrada NO és vàlida

            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            try
            {
                // int.Parse pot llançar: FormatException, OverflowException
                // o ArgumentNullException (si ReadLine retorna null amb Ctrl+Z / Ctrl+D)
                option = int.Parse(Console.ReadLine());

                // Validació de rang: si no es compleix, LLANÇEM nosaltres l'excepció
                if (option < 0 || option > 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(option), ErrorRange);
                }

                // Si arribem aquí no ha saltat cap excepció: entrada vàlida
                isValid = true;
                Console.WriteLine($"You chose: {option}");
            }
            catch (FormatException)              // Text que no és un número: "abc", "3.5", ""
            {
                Console.WriteLine(ErrorNotNumber);
            }
            catch (OverflowException)            // Número que no cap en un int: "99999999999"
            {
                Console.WriteLine(ErrorTooBig);
            }
            catch (ArgumentNullException)        // ReadLine ha retornat null
            {
                Console.WriteLine(ErrorNoInput);
            }
            catch (ArgumentOutOfRangeException)  // La que hem llançat nosaltres pel rang
            {
                Console.WriteLine(ErrorRange);
            }
            finally
            {
                // S'executa SEMPRE: hi hagi error o no
                Console.WriteLine("----------------------------\n");
            }


            {
                if (option == 1)
                {
                    Console.WriteLine(MenuTitle);
                    Console.WriteLine(WELCOME);
                    Console.WriteLine(LINE);
                    int power = 0;
                    int nivel = 1;
                    int Day = 0;
                    int totalHoras = 0;


                    Console.Write("Insert your name: ");
                    nameMage = Console.ReadLine();
                    Console.WriteLine(LINE);

                    Random rnd = new();
                    while (Day < 5)
                    {
                        Day++;



                        power += rnd.Next(1, 11);
                        totalHoras = rnd.Next(1, 25);

                        int nivel_anterior = nivel;
                        nivel = 1 + (power / 10);


                        Console.WriteLine($"⌛ Dia {Day} → {nameMage}, ja has meditat {totalHoras} hores i el teu poder ara és de {power} punts!");


                        if (nivel > nivel_anterior)
                        {
                            Console.WriteLine($"⭐ → {nameMage} ha pujat al nivell {nivel}!");

                        }


                    }
                    if (power < 20)
                    {
                        Console.WriteLine("Repeteixes a 2a convocatòria");
                        Console.WriteLine("Raoden el Elantrí");

                    }

                    else if ((power > 20) && (power < 30))
                    {
                        Console.WriteLine("Encara confons la vareta amb una cullera");
                        Console.WriteLine("Zyn el Buguejat");
                    }

                    else if ((power > 30) && (power < 35))
                    {
                        Console.WriteLine("Ets un Invocador de Brises Màgiques.");
                        Console.WriteLine("Arka Nullpointer");
                    }
                    else if ((power > 35) && (power < 40))
                    {
                        Console.WriteLine("Uau! Pots invocar dracs sense cremar el laboratori!");
                        Console.WriteLine("Elarion de les Brases");
                    }
                    else
                    {
                        Console.WriteLine("Has assolit el rang de Mestre dels Arcans!");
                        Console.WriteLine("ITB - Wizard el Gris");
                    }

        
                }
                else if (option == 2){



                    
                }

            }   
        } while (!isValid || option != 0);
    }
}


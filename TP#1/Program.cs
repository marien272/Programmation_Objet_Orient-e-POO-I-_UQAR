using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Deadstroke_Menu();
    }

    public static void Deadstroke_Menu() {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t\t\t\t\t\n\t\t\t\t\t\t  WELCOME TO THE DEADSTROKE PROGRAMME :) !\n");
            Console.WriteLine("\t\t\t\t\t\t+-----------------------------------------+");
            Console.WriteLine("\t\t\t\t\t\t|      M     M  EEEEE  N   N  U   U       | ");
            Console.WriteLine("\t\t\t\t\t\t|      MM   MM  E      NN  N  U   U       |");
            Console.WriteLine("\t\t\t\t\t\t|      M M M M  EEEE   N N N  U   U       |");
            Console.WriteLine("\t\t\t\t\t\t|      M  M  M  E      N  NN  U   U       |");
            Console.WriteLine("\t\t\t\t\t\t|      M     M  EEEEE  N   N   UUU        |");
            Console.WriteLine("\t\t\t\t\t\t+-----------------------------------------+");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\t\t+-----------------------------------------+");
            Console.WriteLine("\t\t\t\t\t\t|   Choisissez un programme à exécuter :  |");
            Console.WriteLine("\t\t\t\t\t\t|    1. Delta                             |");
            Console.WriteLine("\t\t\t\t\t\t|    2. Division                          |");
            Console.WriteLine("\t\t\t\t\t\t|    3. HexaToBin                         |");
            Console.WriteLine("\t\t\t\t\t\t|    4. EcartType                         |");
            Console.WriteLine("\t\t\t\t\t\t|    5. ClasserPhrase                     |");
            Console.WriteLine("\t\t\t\t\t\t|    6. FusionMots                        |");
            Console.WriteLine("\t\t\t\t\t\t|    7. AffCarracteres                    |");
            Console.WriteLine("\t\t\t\t\t\t|    8. MachineÀSous                      |");
            Console.WriteLine("\t\t\t\t\t\t|    9. QCM                               |");
            Console.WriteLine("\t\t\t\t\t\t|    10. Quitter                          |");
            Console.WriteLine("\t\t\t\t\t\t+-----------------------------------------+");

            Console.Write("\n\t\t\t\t\t\tEntrez votre choix: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Delta(); break;
                case 2: Division(); break;
                case 3: HexaToBin(); break;
                case 4: EcartType(); break;
                case 5: ClasserPhrase(); break;
                case 6: FusionMots(); break;
                case 7: AffCarracteres(); break;
                case 8: MachineÀSous(); break;
                case 9: QCM(); break;
                case 10: return;
                default: 
                    Console.WriteLine("Choix invalide. Veillez réessayer :)");
                    break;
            }

            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }

    public static void Delta()
    {
        Console.Write("Entrez a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Entrez b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Entrez c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
            Console.WriteLine("Pas de solution réelle.");
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"La solution est x = {x}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Les solutions sont x1 = {x1} et x2 = {x2}");
        }
    }

    public static void Division()
    {
        Console.WriteLine("Veuillez saisir le numérateur (vous pouvez utiliser ',' ou '.' pour les décimales) :");
        string inputNumerator = Console.ReadLine();
        Console.WriteLine("Veuillez saisir le dénominateur (vous pouvez utiliser ',' ou '.' pour les décimales) :");
        string inputDenominator = Console.ReadLine();

        inputNumerator = inputNumerator.Replace(',', '.');
        inputDenominator = inputDenominator.Replace(',', '.');

        if (double.TryParse(inputNumerator, out double numerator) &&
            double.TryParse(inputDenominator, out double denominator))
        {
            if (denominator == 0)
            {
                Console.WriteLine("Erreur : Division par zéro n'est pas autorisée.");
                return;
            }

            double quotient = 0;
            double remainder = Math.Abs(numerator);

            while (remainder >= Math.Abs(denominator))
            {
                remainder -= Math.Abs(denominator);
                quotient++;
            }

            if ((numerator < 0 && denominator > 0) || (numerator > 0 && denominator < 0))
            {
                quotient = -quotient;
            }

            if (numerator < 0)
            {
                remainder = -remainder;
            }
            Console.WriteLine($"Résultat de la division : {quotient}");
            Console.WriteLine($"Reste de la division : {remainder}");
        }
        else
        {
            Console.WriteLine("Erreur : Veuillez saisir des nombres valides.");
        }
    }
    public static void HexaToBin()
    {
        Console.WriteLine("Entrez un nombre hexadécimal (sans 0x) :");
        string hexValue = Console.ReadLine().ToUpper();

        string binaryResult = "";

        string[] hexToBin = {
            "0000", "0001", "0010", "0011", 
            "0100", "0101", "0110", "0111", 
            "1000", "1001", "1010", "1011", 
            "1100", "1101", "1110", "1111" 
        };

        foreach (char hexDigit in hexValue)
        {
            int index = -1;

            if (hexDigit >= '0' && hexDigit <= '9')
            {
                index = hexDigit - '0';
            }
            else if (hexDigit >= 'A' && hexDigit <= 'F')
            {
                index = hexDigit - 'A' + 10;
            }
            else
            {
                Console.WriteLine("Caractère hexadécimal invalide.");
                return;
            }
            binaryResult += hexToBin[index];
        }
        Console.WriteLine($"Le nombre hexadécimal {hexValue} en binaire est : {binaryResult}");
    }
    public static void EcartType()
    {
        string input = "";
        double moyenne = 0;
        double ecartType = 0;

        Console.WriteLine("Entrez les éléments du tableau séparés par des espaces (utilisez le point pour les décimales) :");
        input = Console.ReadLine();

        input = input.Replace('.', ',');

        string[] elements = input.Split(' ');
        double[] tableau = new double[elements.Length];

        for (int i = 0; i < elements.Length; i++)
        {
            tableau[i] = double.Parse(elements[i], CultureInfo.CurrentCulture);
        }
        moyenne = CalculerMoyenne(tableau);
        ecartType = CalculerEcartType(tableau, moyenne);
        Console.WriteLine("La moyenne est : " + moyenne);
        Console.WriteLine("L'écart-type est : " + ecartType);
    }
    public static double CalculerMoyenne(double[] tableau)
    {
        double somme = 0;
        for (int i = 0; i < tableau.Length; i++)
        {
            somme += tableau[i];
        }
        return somme / tableau.Length;
    }

    public static double CalculerEcartType(double[] tableau, double moyenne)
    {
        double sommeDesCarres = 0;
        for (int i = 0; i < tableau.Length; i++)
        {
            sommeDesCarres += Math.Pow(tableau[i] - moyenne, 2);
        }
        return Math.Sqrt(sommeDesCarres / tableau.Length);
    }
    public static void ClasserPhrase()
    {
        Console.Write("Entrez une phrase: ");
        string phrase = Console.ReadLine().ToUpper();
        int poids = 0;

        foreach (char c in phrase)
        {
            if (c >= 'A' && c <= 'Z')
            {
                poids += c - 'A' + 1;
            }
        }

        Console.WriteLine($"Le poids de la phrase est: {poids}");
    }
    public static void FusionMots()
    {
        Console.Write("Entrez le premier mot: ");
        string mot1 = Console.ReadLine();
        Console.Write("Entrez le deuxième mot: ");
        string mot2 = Console.ReadLine();
        string combinedWord = "";
        int GrandMots = Math.Max(mot1.Length, mot2.Length);

        for (int i = 0; i < GrandMots; i++)
        {
            if (i < mot1.Length) combinedWord += mot1[i];
            if (i < mot2.Length) combinedWord += mot2[i];
        }

        Console.WriteLine($"Le mot fusionné est: {combinedWord}");
    }
    static void AffCarracteres()
    {
        int lettresDansLigne = 0;
        int nbLignes = 0;
        char lettreActuelle = 'A';
        int nbLettres = 0;

        Console.Write("Entrez le nombre de lignes: ");
        nbLignes = int.Parse(Console.ReadLine());
        Console.Write("Entrez le nombre de lettres à utiliser : ");
        nbLettres = int.Parse(Console.ReadLine());

        for (int i = 0; i < nbLignes; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            lettresDansLigne = nbLignes - i;
            for (int k = 0; k < lettresDansLigne; k++) {
                Console.Write(lettreActuelle + " ");
                lettreActuelle++;
                if (lettreActuelle > (char)('A' + nbLettres - 1))
                {
                    lettreActuelle = 'A';
                }
            }
            Console.WriteLine();
        }
    }
    public static void MachineÀSous()
    {
        Console.Write("Entrez votre montant: ");
        double montant = double.Parse(Console.ReadLine());

        Random random = new Random();
        
        int[] numeros = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numeros[i] = random.Next(0, 10);
        }

        Console.WriteLine("Numéros générés : " + string.Join(", ", numeros));

        if (TousEgaux(numeros))
        {
            int jackpot = 1;
            double gain = Math.Pow(montant, 5);
           
         // Partie de code pour désactiver le jackpot
        /*
        {
            int k = 1;
            jackpot = 0;
            for (int i = 0; i < 5; i++) {
            numeros[i] = k++;
            }
        }
        */
        if (jackpot == 1) {
            Console.WriteLine($"Félicitations ! Vous avez gagné le jackpot : {gain}");
        } else {
            Console.WriteLine("Désolé, vous n'avez rien gagné.");
        }
        }
        else if (Repetitions(numeros, 3) || Repetitions(numeros, 4))
        {
            Console.WriteLine($"Vous récupérez votre montant : {montant}");
        }
        else
        {
            Console.WriteLine("Désolé, vous n'avez rien gagné.");
        }


    }

    static bool TousEgaux(int[] numeros)
    {
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] != numeros[0])
            {
                return false;
            }
        }
        return true;
    }

    static bool Repetitions(int[] numeros, int repetitions)
    {
        int[] compte = new int[10];

        foreach (int numero in numeros)
        {
            compte[numero]++;
        }

        for (int i = 0; i < compte.Length; i++)
        {
            if (compte[i] == repetitions)
            {
                return true;
            }
        }
        return false;
    }

    public static void QCM()
    {
        string[] questions = new string[]
        {
            "Quelle est la couleur du ciel?",
            "Quel est l'animal le plus rapide?",
            "Quelle est la capitale de la France?",
            "Quel est le plus grand océan?",
            "Qui a écrit 'Les Misérables'?",
            "Quel est le symbole chimique de l'eau?",
            "Quelle est la monnaie du Japon?",
            "Qui a découvert l'Amérique?",
            "Quel est le plus haut sommet du monde?",
            "Qui a peint la Mona Lisa?"
        };

        string[][] options = new string[][]
        {
            new string[] { "A. Bleu", "B. Vert", "C. Rouge" },
            new string[] { "A. Lion", "B. Guépard", "C. Éléphant" },
            new string[] { "A. Paris", "B. Londres", "C. Berlin" },
            new string[] { "A. Atlantique", "B. Pacifique", "C. Indien" },
            new string[] { "A. Hugo", "B. Balzac", "C. Zola" },
            new string[] { "A. H2O", "B. O2", "C. CO2" },
            new string[] { "A. Yen", "B. Dollar", "C. Euro" },
            new string[] { "A. Colomb", "B. Magellan", "C. Vasco" },
            new string[] { "A. Everest", "B. K2", "C. Mont Blanc" },
            new string[] { "A. Van Gogh", "B. Picasso", "C. Léonard de Vinci" }
        };

        char[] correctAnswers = new char[] { 'A', 'B', 'A', 'B', 'A', 'A', 'A', 'A', 'A', 'C' };
        int Points = 0;
        Random rand = new Random();
        HashSet<int> askedQuestions = new HashSet<int>();
        int questionIndex;        
        
        for (int i = 0; i < 4; i++)
        {
            do
            {
                questionIndex = rand.Next(0, questions.Length);
            } while (askedQuestions.Contains(questionIndex));

            askedQuestions.Add(questionIndex);

            Console.WriteLine($"Question {i + 1}: {questions[questionIndex]}");
            foreach (var option in options[questionIndex])
            {
                Console.WriteLine(option);
            }

            char userAnswer = char.ToUpper(Console.ReadLine()[0]);
            if (userAnswer == correctAnswers[questionIndex])
            {
                Console.WriteLine("Bonne réponse!");
                Points += 1;
            }
            else
            {
                Console.WriteLine($"Mauvaise réponse! La bonne réponse est {correctAnswers[questionIndex]}");
            }
        }
        switch (Points)
        {
            case 1:
                Console.WriteLine("Résultat: E");
                break;
            case 2:
                Console.WriteLine("Résultat: D");
                break;
            case 3:
                Console.WriteLine("Résultat: B");
                break;
            case 4:
                Console.WriteLine("Résultat: A");
                break;
            default:
                Console.WriteLine("Résultat: E");
                break;
        }
    }
}
 
namespace HOMEWORK3_QUADRATIC_YPARKHOMENKO
{
    internal class Program
    {
        //HILLEL ONLINE PRIVATE COMPUTER SCHOOL, C# BASIC MAXIM KABAKOV'S COURSE, HOMEWORK №3 "QUADRATIC", PARHOMENKO YAROSLAV.

        static void Main() //БУЛО ЗНАЙДЕНО ПО ПОСИЛАННІ ДАЛІ, ЯК МОЖНА ПРИБРАТИ АРГУМЕНТИ MAIN — https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/program-structure/main-command-line
        {

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");

            Console.WriteLine($"\nTHIS PROGRAM SOLVING A QUADRATIC EQUATIONS OF THE FORM\n\nAx\u00B2 + Bx + C = 0,\n\nAND THE SECOND FORM\n\n(Px + Q)(Rx + S) = 0,\n\nA, P, B, Q, C, R, S — ARE COEFFITIENTS THE EACH OF THEM IS AN INTEGER NUMBER (MEANS NO FRACTIONAL PART) THAT CAN BE LOWER THAN 0, THE POSSIBLE RANGE OF INTEGER VALUES FOR A SINGLE VARIABLE ON ELECTRONIC CALCULATION MACHINE IS ({int.MinValue}, {int.MaxValue})\n\n");
            //string ROOTS_TO_STRING = $"{TYPE_OF_QUADRATIC()}{THE_TYPE_OF_QUADRATIC_1()}";
            //Console.WriteLine("E!");
            //try
            //{
            //Console.WriteLine($"{TYPE_OF_QUADRATIC()},//{THE_TYPE_OF_QUADRATIC_1}");
            //}

            //catch (FormatException)
            //{
            //Console.WriteLine($"{THE_TYPE_OF_QUADRATIC_1()}");
            //}
            //Console.WriteLine(ROOTS_TO_STRING);
            //SHOW_RESULTS_TO_USER();

            byte CHECK_CONSOLE_AT_START = 0;
            string SECOND_TYPE = "UNASSIGNED"; //ASSIGNMENT OF STRING VARIABLE THAT REQUIRED FOR OUR MECHANISM. TO READ IT IN "CATCH" PROGRAM.

            try //CHECKING FOR EXCEPTION THE FIRST METHOD FOR PROBLEM SOLUTIONS.
            {
                Console.WriteLine("ENTER ANY NUMBER FROM 0 TO 255 TO SOLVE FIRST TYPE OF QUADRATIC EQUATION, OR ANY OTHER CHARACTER TO SOLVE THE SECOND.");
                CHECK_CONSOLE_AT_START = byte.Parse(Console.ReadLine());
                string FIRST_TYPE = TYPE_OF_QUADRATIC(); //ON THIS POINT ELECTRONIC CALCULATION MACHINE START PROCESSING OF METHOD ONE.
                Console.WriteLine($"\n{FIRST_TYPE}"); //IF NO MISTAKE, THIS COMMAND SHOULD BE PROCESSED.
            }

            catch (FormatException) //IF A USER TYPES SOME OTHER THINGS THAN NUMBER IN THE FIRST METHOD "TRY", THE ELECTRONIC CALCULATION MACHINE STARTING TO PROCESS "CATCH".
            {
                SECOND_TYPE = THE_TYPE_OF_QUADRATIC_1(); //STARTING TO PROCESS SECOND METHOD.
                Console.WriteLine($"\n{SECOND_TYPE}");
            }

        }

        static string TYPE_OF_QUADRATIC(int A = 0, int B = 0, int C = 0)//CREATING METHOD WITH ASSIGNED VARIABLES.
        {
            float x_1 = float.PositiveInfinity; //VARIABLE OF THE FIRST ROOT INSIDE OF THE FIRST METHOD.
            float x_2 = float.NegativeInfinity; //VARIABLE OF THE SECOND ROOT INSIDE OF THE FIRST METHOD.
            float DISCR_CHECK = 0f;
            int CONST_0 = 1;
            uint CHECK_CONST = 1;
            float DISCRIMINANT = 0f;
            int A_CHECK = 0;

            try
            {
                Console.WriteLine("PLEASE, TYPE A NUMERIC INTEGER — COEFFICIENT:");
                A = int.Parse(Console.ReadLine());
                A_CHECK = CONST_0 / A;

                //return "SOLVED!";
            }

            catch (FormatException)
            {
                Main();
                //THE_TYPE_OF_QUADRATIC_1();
                //return $"{THE_TYPE_OF_QUADRATIC_1()}";
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("PLEASE, TYPE B NUMERIC INTEGER — COEFFICIENT:");
                B = int.Parse(Console.ReadLine());
                Console.WriteLine("PLEASE, TYPE C NUMERIC INTEGER — COEFFICIENT:");
                C = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nYour equation is {B}x + {C} = 0.");
                x_1 = (-1) * (float)(C + 0 + 0) / B; //ATTEMPTS TO REMOVE NEGATIVE ZERO FROM THE ANSWER STRING. ITS FAILED.
                Console.WriteLine($"\nThe root of equation is equal to {x_1}.");
                Main();
                //return $"The root of equation is equal to {x_1}.";

            }

            try
            {
                Console.WriteLine("PLEASE, TYPE B NUMERIC INTEGER — COEFFICIENT:");
                B = int.Parse(Console.ReadLine());

                Console.WriteLine("PLEASE, TYPE C NUMERIC INTEGER — COEFFICIENT:");
                C = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nYour equation is ({A})x\u00B2 + ({B})x + ({C}) = 0.");

                //A SECTION OF MATHEMATIC OPERATIONS.

                DISCRIMINANT = (float)(B * B - 4 * A * C); //A MOMENT CAN BE POTENTIAL COLLAPSE DUE TO OverflowException FOR AN EXAMPLE.
                //Console.WriteLine($"DISCRIMINANT = {DISCRIMINANT}");
                DISCR_CHECK = CONST_0 / (Math.Sign((int)DISCRIMINANT) + CHECK_CONST); //PROVIDING CHECK OF DISCRIMINANT IS NEGATIVE RANGE OF NUMBERS. IF SO — MAKING DivideByZeroException FOR ECM.
                x_1 = (float)(-B + Math.Sqrt(DISCRIMINANT)) / (2 * A);
                x_2 = (float)(-B - Math.Sqrt(DISCRIMINANT)) / (2 * A);
            }

            catch (FormatException)
            {
                Main();
                /**{
                //        Console.WriteLine("PLEACE, TYPE P — COEFFICIENT, IF YOU HAVE SECOND TYPE OF EQUATION TO SOLVE, LEFT THE FIELD EMPTY AND PRESS \"ENTER\"");
                //        P = int.Parse(Console.ReadLine());

                //        Console.WriteLine("PLEACE, TYPE P — COEFFICIENT, IF YOU HAVE SECOND TYPE OF EQUATION TO SOLVE, LEFT THE FIELD EMPTY AND PRESS \"ENTER\"");
                //        Q = int.Parse(Console.ReadLine());

                //        Console.WriteLine("PLEACE, TYPE P — COEFFICIENT, IF YOU HAVE SECOND TYPE OF EQUATION TO SOLVE, LEFT THE FIELD EMPTY AND PRESS \"ENTER\"");
                //        R = int.Parse(Console.ReadLine());

                //        Console.WriteLine("PLEACE, TYPE P — COEFFICIENT, IF YOU HAVE SECOND TYPE OF EQUATION TO SOLVE, LEFT THE FIELD EMPTY AND PRESS \"ENTER\"");
                //        S = int.Parse(Console.ReadLine());
                }**/
                //THE_TYPE_OF_QUADRATIC_1();
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine($"YOUR QUADRATIC EQUATION {A}x\u00B2 + ({B})x + ({C}) = 0 HAS NO ANY SOLUTIONS!");
            }

            //finally
            //{

            //}
            return $"The first root is equal to {x_1} and the second to {x_2}."; //DATA THAT FIRST METHOD LEFT AFTER PROCESSING.
        }

        //static void SHOW_RESULTS_TO_USER(string? ROOTS)
        //{
        //    //ROOTS = TYPE_OF_QUADRATIC();
        //    //Console.WriteLine(ROOTS);
        //    //string X_1 = $"{TYPE_OF_QUADRATIC()}"; 
        //    //string ROOTS = $"The roots of quadratic ";
        //    //return ROOTS;
        //}

        static string THE_TYPE_OF_QUADRATIC_1(int P = 0, int Q = 0, int R = 0, int S = 0) //THE 'HEAD' OF SECOND METHOD WITH ASSIGNED VARIABLES.
        {
            float x_1 = float.PositiveInfinity; //VARIABLE OF THE FIRST ROOT INSIDE OF THE SECOND METHOD.
            float x_2 = float.NegativeInfinity; //VARIABLE OF THE SECOND ROOT INSIDE OF THE SECOND METHOD.
            int CONST_0 = 1;
            int PR_CHECK = 0;
            int P_CHECK = 0;
            int R_CHECK = 0;

            try
            {
                Console.WriteLine("PLEASE, TYPE P NUMERIC INTEGER — COEFFICIENT:");
                P = int.Parse(Console.ReadLine());

                P_CHECK = CONST_0 / P; //CHECKS IF P = 0.
            }

            catch (FormatException)
            {
                Main();
                //return;
                //TYPE_OF_QUADRATIC(); //REDIRECT ECM TO FIRST METHOD IF IN SECOND USER MADE FORMAT MISTAKE OF INPUT.
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("PLEASE, TYPE R NUMERIC INTEGER — COEFFICIENT:");
                R = int.Parse(Console.ReadLine());
                Console.WriteLine("PLEASE, TYPE S NUMERIC INTEGER — COEFFICIENT:");
                S = int.Parse(Console.ReadLine());

                float R_0 = (float)R; //PROTECTION FROM ZERO-VALUE IN DivideByZeroException BY USING FLOAT NUMERIC VARIABLES INSTEAD, FLOAT IS A DIFFICULT TYPE TO CALCULATE ZERO SO ITS CAN BE DIVIDED ON TO.
                float S_0 = (float)S;

                x_1 = -S_0 / R_0;

                //string x_1s = x_1.ToString();
                //double x_1d = (double)x_1;

                return $"In case of the different equation {R}x + ({S}) = 0, the root is {x_1}.";
            }

            try
            {
                Console.WriteLine("PLEASE, TYPE R NUMERIC INTEGER — COEFFICIENT:");
                R = int.Parse(Console.ReadLine());

                R_CHECK = CONST_0 / R; //CHECKS IF R = 0.

            }

            catch (FormatException)
            {
                Main();
                //TYPE_OF_QUADRATIC();
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("PLEASE, TYPE P NUMERIC INTEGER — COEFFICIENT:");
                P = int.Parse(Console.ReadLine());
                Console.WriteLine("PLEASE, TYPE Q NUMERIC INTEGER — COEFFICIENT:");
                Q = int.Parse(Console.ReadLine());

                float P_0 = (float)P; //PROTECTION FROM ZERO-VALUE
                float Q_0 = (float)Q;

                x_1 = -Q_0 / P_0;
                return $"In case of the different equation {P}x + ({Q}) = 0, the root is {x_1}.";
            }

            try
            {
                Console.WriteLine("PLEASE, TYPE Q NUMERIC INTEGER — COEFFICIENT:");
                Q = int.Parse(Console.ReadLine());

                Console.WriteLine("PLEASE, TYPE S NUMERIC INTEGER — COEFFICIENT:");
                S = int.Parse(Console.ReadLine());
                Console.WriteLine($"Your equation is ({P}x + ({Q}))({R}x + ({S})) = 0.");

                //MATHEMATIC OPERATIONS.

                PR_CHECK = CONST_0 / (Math.Max(0, P) + Math.Max(0, R)); //WITH HELP OF SPECIAL PROGRAM THAT RETURN ONLY LARGER NUMBER FROM TWO GIVEN, WE CHECKING IF BOTH OF COEFFICIENTS NEAR x IS EQUAL TO ZERO, THEN REDIRECTING ECM TO catch.
                x_1 = (float)-Q / P;
                x_2 = (float)-S / R;
            }

            catch (FormatException)
            {
                //P = 0;
                //Q = 0;
                //R = 0;
                //S = 0;
                Main();
                //TYPE_OF_QUADRATIC(); //REDIRECT ECM TO FIRST METHOD IF IN SECOND USER MADE FORMAT MISTAKE OF INPUT.
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine($"YOUR EQUATION ({P}x + ({R}))({Q}x + ({S})) = 0 HAS NO ANY SOLUTIONS!");
                return $"x = {x_1}";
            }

            return $"In case of the different one equation, the first root is {x_1} and the second root is {x_2}."; //THE INFORMATION THAT SECOND METHOD CREATING IN A RESULT OF ITS WORK.
        }

        //static void SHOW_RESULTS_TO_USER_1(string? ROOTS)
        //{
        //    ROOTS = THE_TYPE_OF_QUADRATIC_1();
        //    Console.WriteLine(ROOTS);
        //}
    }
}
